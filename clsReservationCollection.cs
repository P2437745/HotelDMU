using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ClassLibrary
{
    public class clsReservationCollection
    {
        //private data member for thie list 
        clsDataConnection DataConnection = new clsDataConnection();
        //private data member thisReservtion
        clsReservation mThisReservation = new clsReservation();



        public clsReservationCollection()
        {
            DataConnection = new clsDataConnection();

            DataConnection.Execute("sproc_tblReservation_SelectedAll");//execute the query

        }




        public List<clsReservation> ReservationList

        {
            get
            {

                List<clsReservation> mReservationList = new List<clsReservation>();
                Int32 ReservationID;
                Int32 NumberAdults;
                Int32 NumberRoom;
                Int32 NumberChildren;
                DateTime DateAdded;
                DateTime DueDate;
                Boolean Active;
                Int32 RecordCount;
                Int32 Index = 0;

                RecordCount = DataConnection.Count;
                ReservationID = Convert.ToInt32(DataConnection.DataTable.Rows[0]["ReservationID"]);


                while (Index < RecordCount)
                {
                    //create a blank addrress 
                    clsReservation AnReservation = new clsReservation();
                    //read in the feilds from the current record
                    AnReservation.Active = Convert.ToBoolean(DataConnection.DataTable.Rows[Index]["Active"]);
                    AnReservation.DateAdded = Convert.ToDateTime(DataConnection.DataTable.Rows[Index]["DateAdded"]);
                    AnReservation.DueDate = Convert.ToDateTime(DataConnection.DataTable.Rows[Index]["DueDate"]);
                    AnReservation.CancelationFee = Convert.ToInt32(DataConnection.DataTable.Rows[Index]["CancelationFee"]);
                    AnReservation.ReservationID = Convert.ToInt32(DataConnection.DataTable.Rows[Index]["ReservationID"]);
                    AnReservation.NumberAdult = Convert.ToInt32(DataConnection.DataTable.Rows[Index]["NumberAdult"]);
                    AnReservation.NumberChild = Convert.ToInt32(DataConnection.DataTable.Rows[Index]["NumberChild"]);
                    AnReservation.NumberRoom = Convert.ToInt32(DataConnection.DataTable.Rows[Index]["NumberRoom"]);
                    //add the record to the private data member
                    mThisReservation.Add(AnReservation);
                    //point at the next record
                    Index++;
                }







                //return the private data
                return mReservationList;

            }

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public clsReservation ThisReservation
        {
            get
            {

                return mThisReservation;
            }
            set
            {
                mThisReservation = value;
            }
        }

        public Int32 Add()
        {


            //connect to the database
            clsDataConnection NewReservation = new clsDataConnection();
            //add the parameters
            NewReservation.AddParameter("@ReservationID", mThisReservation.ReservationID);
            NewReservation.AddParameter("@DateAdded", mThisReservation.DateAdded);
            NewReservation.AddParameter("@Acive", mThisReservation.Active);
            NewReservation.AddParameter("@DueDate", mThisReservation.DueDate);
            NewReservation.AddParameter("@CancelationFee", mThisReservation.CancelationFee);
            NewReservation.AddParameter("@NumberAdult", mThisReservation.NumberAdult);
            NewReservation.AddParameter("@NumberChild", mThisReservation.NumberChild);
            //execute teh query returning the primary key value
            return NewReservation.Execute("sproc_tblReservation_Insert");

        }

        public int Count
        {
            get
            {
                return DataConnection.Count;

            }
            set
            {

            }
        }





        public void Update()
        {

            clsDataConnection DB = new clsDataConnection();
            //add the parameters
            DB.AddParameter("@ReservationID", mThisReservation.ReservationID);
            DB.AddParameter("@Active", mThisReservation.Active);
            DB.AddParameter("@DateAdded", mThisReservation.DateAdded);
            DB.AddParameter("@DueDate", mThisReservation.DueDate);
            DB.AddParameter("@CancelationFee", mThisReservation.CancelationFee);
            DB.AddParameter("@NumberAdult", mThisReservation.NumberAdult);
            DB.AddParameter("@NumberChild", mThisReservation.NumberChild);
            //execute the query 
            DB.Execute("sproc_tblReservation_Update");
        }






    }
}