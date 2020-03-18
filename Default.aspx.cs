using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 RoomtypeID;
    //this function handles the load event for the page 
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayRoomtype();
        }

    }
    void DisplayRoomtype()
    {
        //create an instance of the roomtype collection
        clsRoomtypeCollection Roomtype = new clsRoomtypeCollection();
        //set the data to source the list of roomtypes in the collection
        lstRoomtype.DataSource = Roomtype.RoomtypeList;
        //set the name of the primary key
        lstRoomtype.DataValueField = "RoomtypeID";
        //set the  data field to display 
        lstRoomtype.DataTextField = "Roomtype";
        //bind the data to the list 
        lstRoomtype.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 RoomtypeID;
        //if a ecord has been selected from the list 
        if (lstRoomtype.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            RoomtypeID = Convert.ToInt32(lstRoomtype.SelectedValue);
            //store the data in the session object 
            Session["RoomtypeID"] = RoomtypeID;
            //rdirect to the delete page 
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error 
            lblerror.Text = "Please select a record to delete from the list";
        }
    }



    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this new record 
        Session["RoomtypeID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("ARoomType.aspx");
    }

    protected void Button3_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 RoomtypeID;
        //if a ecord has been selected from the list 
        if (lstRoomtype.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            RoomtypeID = Convert.ToInt32(lstRoomtype.SelectedValue);
            //store the data in the session object 
            Session["RoomtypeID"] = RoomtypeID;
            //rdirect to the edit page 
            Response.Redirect("ARoomType.aspx");
        }
        else //if no record has been selected 
        {
            //display an error 
            lblerror.Text = "Please select a record to Edit from the list";
        }
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {

    }
}