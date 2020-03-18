using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ClassLibrary
{
    public class clsReservation
    {
        //private data member for the reservationID property
        private Int32 mReservationID;

        public int ReservationID


        {
            get
            {

                return mReservationID;
            }



            set
            {
                //set the value of the private data
                mReservationID = value;
            }




        }









        private Boolean mActive;
        public bool Active
        {
            get
            {
                //return the private data 
                return mActive;
            }

            set
            {
                //set the private data 
                mActive = value;
            }
        }


        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }

        }



        private Int32 mRoomID;
        public int RoomID
        {
            get
            {
                return mRoomID;
            }
            set
            {
                mRoomID = value;
            }
        }


        private Int32 mRoomCost;

        public int RoomCost
        {
            get
            {
                return mRoomCost;
            }

            set
            {
                mRoomCost = value;
            }



        }



        //check this!!     public int ReservationID { get; set; }


        private Int32 mCancelationFee;

        public int CancelationFee
        {
            get
            {
                return mCancelationFee;
            }

            set
            {
                mCancelationFee = value;
            }




        }


        private DateTime mDateDue;
        public DateTime DueDate
        {

            get
            {
                return mDateDue;
            }
            set
            {
                mDateDue = value;
            }

        }



        private Int32 mNumberChild;

        public int NumberChild
        {
            get
            {
                return mNumberChild;
            }

            set
            {
                mNumberChild = value;
            }
        }

        internal void Add(clsReservation anReservation)
        {
            throw new NotImplementedException();
        }

        private Int32 mNumberAdult;
        public int NumberAdult
        {
            get
            {
                return mNumberAdult;
            }

            set
            {
                mNumberAdult = value;
            }

        }

        private Int32 mNumberRoom;
        public int NumberRoom

        {
            get
            {
                return mNumberRoom;
            }

            set
            {
                mNumberRoom = value;
            }

        }

        public string Valid(string NumberAdult, string DueDate, string NumberChild, string DateAdded, string NumberRoom)
        {
            String Error = "";
            //if NumberAdult is blank
            if (NumberAdult.Length == 0)
            {
                //record the error
                Error = Error + "The Number of Adults cannot be blank :";
            }

            if (NumberAdult.Length == 3)
            {
                //record the error 
                Error = Error + "The Number of Adults must be less than 3 characters : ";

            }




            if (NumberChild.Length == 0)
            {
                //record the error
                Error = Error + "The Number of Adults cannot be blank :";
            }

            if (NumberChild.Length == 3)
            {
                //record the error 
                Error = Error + "The Number of Adults must be less than 3 characters : ";

            }



            if (NumberRoom.Length == 0)
            {
                //record the error
                Error = Error + "The Number of Adults cannot be blank :";
            }

            if (NumberRoom.Length == 3)
            {
                //record the error 
                Error = Error + "The Number of Adults must be less than 3 characters : ";

            }





            try
            {

                DateTime DateAdded;

                DateAdded = Convert.ToDateTime(DateAdded);



                //return error message
                return Error;

            }
            catch
            {
                //record the error
                Error = Error + "the data was not a valid date";
            }



            try
            {

                DateTemp = Convert.ToDateTime(DueDate);
                DateTime DateTemp = default(DateTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "Date cannot be in the future";
                }

                //return error message
                return Error;

            }
            catch
            {
                //record the error
                Error = Error + "the data was not a valid date";
            }

            //return error message
            return Error;

        }








        public bool Find(int ReservationID)
        {
            //initialise the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the  parameter
            DB.AddParameter("@ReservationID", ReservationID);
            //execute  the parameter for the reservation not to search for 
            DB.Execute("sproc_tblReservation_FilterByReservationID");
            //if record is found




            if (DB.Count == 1)
            {
                //copy data from database to private data member
                mReservationID = Convert.ToInt32(DB.DataTable.Rows[0]["ReservationID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDateDue = Convert.ToDateTime(DB.DataTable.Rows[0]["DueDate"]);
                mCancelationFee = Convert.ToInt32(DB.DataTable.Rows[0]["CancelationFee"]);
                mRoomCost = Convert.ToInt32(DB.DataTable.Rows[0]["RoomCost"]);
                mNumberAdult = Convert.ToInt32(DB.DataTable.Rows[0]["NumberAdult"]);
                mNumberChild = Convert.ToInt32(DB.DataTable.Rows[0]["NumberChild"]);
                mNumberRoom = Convert.ToInt32(DB.DataTable.Rows[0]["NumberRoom"]);


                //return success
                return true;
            }
            else
            {
                //return failure
                return false;
            }
        }

        public string Valid(string someReservation)
        {
            throw new NotImplementedException();
        }
    }
}