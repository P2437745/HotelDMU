﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 RoomtypeID;
    protected void Page_Load(object sender, EventArgs e)
    {

        //get the roomtype to be deleted from the session object
        RoomtypeID = Convert.ToInt32(Session["RoomtypeID"]);
    }

    void DeleteRoomtype()
    {
        //function to delete the selected record 

        //create a new instance of the Roomtype 
        clsRoomtypeCollection RoomType = new clsRoomtypeCollection();
        //find the record to delete 
        RoomType.ThisRoomtype.Find(RoomtypeID);
        //Delete the record 
        RoomType.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        DeleteRoomtype();
        //redirect back to the main page 
        Response.Redirect("Default.aspx");
    }
}