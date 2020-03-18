using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;

namespace ClassLibrary
{
    public class clsRoomtypeCollection
    {


        //private data memeber for the list 
        List<clsRoomType> mRoomtypeList = new List<clsRoomType>();
        //private data member thisRoomtype 
        clsRoomType mThisRoomtype = new clsRoomType();

        public List<clsRoomType> RoomtypeList
        {
            get
            {
                //return the private data 
                return mRoomtypeList;
            }
            set
            {
                //set the private data 
                mRoomtypeList = value;
            }
        }
        public clsRoomType ThisRoomtype
        {
            get
            {
                //return the private data
                return mThisRoomtype;
            }
            set
            {
                //set the private data 
                mThisRoomtype = value;
            }
        }
        public int Count
        {
            get
            {
                return mRoomtypeList.Count;
            }
        }

        //constructor for the class
        public clsRoomtypeCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblRoomtype_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
        public int Add()
        {
            //adds a new record to the data base based on the values of mThisRoomtype
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@RoomFloorNo", mThisRoomtype.RoomFloorNo);
            DB.AddParameter("@RoomtypeSize", mThisRoomtype.RoomtypeSize);
            DB.AddParameter("@Roomtype", mThisRoomtype.Roomtype);
            DB.AddParameter("@DateTime", mThisRoomtype.DateTime);
            DB.AddParameter("@Active", mThisRoomtype.Active);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblRoomtype_Insert");


        }
        public void Delete()
        {
            //delete the record pointed to by ThisRoomtype 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the stored procedur 
            DB.AddParameter("@RoomtypeID", mThisRoomtype.RoomtypeID);
            //execute the stored procedure 
            DB.Execute("sproc_tblRoomtype_Delete");
        }
        public void Update()
        {
            //update an existing record based on the vlaues of ThisRoomtype 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("RoomtypeID", mThisRoomtype.RoomtypeID);
            DB.AddParameter("@RoomtypeFloorNo", mThisRoomtype.RoomFloorNo);
            DB.AddParameter("@RoomtypeSize", mThisRoomtype.RoomtypeSize);
            DB.AddParameter("@Roomtype", mThisRoomtype.Roomtype);
            DB.AddParameter("@DateTime", mThisRoomtype.DateTime);
            DB.AddParameter("@Active", mThisRoomtype.Active);
            //execute the stored procedure 
            DB.Execute("sproc_tblRoomtype_Update");

        }

        public void ReportByRoomtype(string Roomtype)
        {
            //filters the records based on a roomtype 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the roomtype parameter to the database 
            DB.AddParameter("@RoomtypeID", Roomtype);
            //execute the stored procedure 
            DB.Execute("sproc_tblRoomtype_FilterByRoomtype");
            //Populate the array list 
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index 
            //var for the index 
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //get the cont of records 
            RecordCount = DB.Count;
            //clear the private array list 
            mRoomtypeList = new List<clsRoomType>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank roomtype 
                clsRoomType AnRoomtype = new clsRoomType();
                //read in the fileds from the current record 
                mThisRoomtype.Active = false;// Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                mThisRoomtype.RoomtypeID = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomtypeID"]);
                mThisRoomtype.RoomFloorNo = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomtypeFloorNo"]);
                mThisRoomtype.RoomtypeSize = Convert.ToString(DB.DataTable.Rows[Index]["RoomtypeSize"]);
                mThisRoomtype.Roomtype = Convert.ToString(DB.DataTable.Rows[Index]["Roomtype"]);
                mThisRoomtype.DateTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateTime"]);
                //add the record to the private data member 
                mRoomtypeList.Add(mThisRoomtype);
                //point at the next record 
                Index++;
            }
        }


    }
}