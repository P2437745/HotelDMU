using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ClassLibrary
{
    public class clsRoomType
    {
        //private data member for the RoomtypeID
        private Int32 mRoomtypeID;
        //private data member for RoomtypeFloorNo
        private Int32 mRoomtypeFloorNo;
        //private data member for RoomtypeSize
        private string mRoomtypeSize;
        //priate data member for Roomtype
        private string mRoomtype;
        //private data member for DateAdded
        private DateTime mDateTime;
        private Boolean mActive;






        // public bool Active { get; set; }

        public bool Find(int RoomtypeID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the RoomtypeID to search for 
            DB.AddParameter("@RoomtypeID", RoomtypeID);
            DB.Execute("sproc_tblRoomtype_FilterByRoomtype");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members 
                mRoomtypeID = Convert.ToInt32(DB.DataTable.Rows[0]["RoomtypeID"]);
                mRoomtypeFloorNo = Convert.ToInt32(DB.DataTable.Rows[0]["RoomtypeFloorNo"]);
                mRoomtypeSize = Convert.ToString(DB.DataTable.Rows[0]["RoomtypeSize"]);
                mRoomtype = Convert.ToString(DB.DataTable.Rows[0]["Roomtype"]);
                mDateTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTime"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK 
                return true;
            }
            //if no recrod is found
            else
            {
                //return fasle indicating a problem
                return false;
            }
        }

        public string Valid(string text1, string text2, string text3, string text4, string text)
        {
            return "";
        }

        // public bool Find(int RoomtypeID)
        //{
        //always true 
        // return true;
        // }
        public int RoomtypeID
        {
            get
            {
                //return the private data 
                return mRoomtypeID;
            }
            set
            {
                //set the value of the private data member 
                mRoomtypeID = value;
            }

        }
        public DateTime DateTime
        {
            get
            {
                //return the private data 
                return mDateTime;
            }
            set
            {
                //set the private data 
                mDateTime = value;
            }
        }
        public int RoomFloorNo
        {
            get
            {
                //retrun the private data
                return mRoomtypeFloorNo;
            }
            set
            {
                //set the private data 
                mRoomtypeFloorNo = value;
            }
        }
        public string RoomtypeSize
        {
            get
            {
                //return the private data 
                return mRoomtypeSize;
            }
            set
            {
                //set the private data
                mRoomtypeSize = value;
            }
        }
        public string Roomtype
        {
            get
            {
                //return the private data 
                return mRoomtype;
            }
            set
            {
                //set the private data 
                mRoomtype = value;
            }
        }
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



        public string Valid(string RoomtypeFloorNo, string RoomtypeSize, string Roomtype, string DateTime)
        {
            //create a string variable to store the error 
            String Error = "";
            //if the RoomtypeFloorNo is blank 
            if (RoomtypeFloorNo.Length == 0)
            {
                //RECORD THE ERROR 
                Error = Error + "The RoomtypeFloorNo may not be blank";
            }
            if (RoomtypeFloorNo.Length > 50)
            {
                //record the error 
                Error = Error + "The room floor number must be less than 6 :";
            }
            if (RoomtypeSize.Length == 0)
            {
                //RECORD THE ERROR 
                Error = Error + "The Room size may not be blank";
            }
            if (RoomtypeSize.Length < 6)
            {
                //record the error 
                Error = Error + "The room size must be less than 6 :";
            }
            if (Roomtype.Length == 0)
            {
                //RECORD THE ERROR 
                Error = Error + "The Room size may not be blank";
            }
            if (Roomtype.Length < 6)
            {
                //record the error 
                Error = Error + "The room size must be less than 6 :";
            }
            
            return Error;
        }


    }
}