using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class RoomTypeViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsRoomtype
        clsRoomType ARoomType = new clsRoomType();
        //get the data from the session object
        ARoomType = (clsRoomType)Session["ARoomType"];
        //display the RoomID for this entry 
        Response.Write(ARoomType);
    }
}