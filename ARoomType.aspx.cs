using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class ARoomType : System.Web.UI.Page
{
    Int32 RoomtypeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of roomtype to be processed 
        RoomtypeID = Convert.ToInt32(Session["RoomypeID"]);
        if (IsPostBack == false)
        {
            //populate the list of roomtypes
            DisplayRoomtype();
            if (RoomtypeID != -1)
            {
                //display the current data for the record 
                DisplayRoomtype();
            }
        }
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        //redirect to the main page
       Response.Redirect("Default.aspx");

       if (RoomtypeID == -1)
       {
       //     //Add the new record 
         Add();
       }
       else
       {
            //update the record 
           Update();
       }


    }

    void Add()
    {
        //create an instance of the Roomtype
        clsRoomtypeCollection Roomtype = new clsRoomtypeCollection();
        //validate the data on the web form 
        String Error = Roomtype.ThisRoomtype.Valid(txtRoomID.Text, txtRoomFloor.Text, txtRoomType.Text, txtRoomType.Text, txtDateAdded.Text);
        //if the data is OK then add it to the subject 
        if (Error == "")
        {
            //get the data entered by the user 
            Roomtype.ThisRoomtype.RoomtypeID = Convert.ToInt32(txtRoomID.Text);
            Roomtype.ThisRoomtype.RoomFloorNo = Convert.ToInt32(txtRoomFloor.Text);
            Roomtype.ThisRoomtype.RoomtypeSize = txtRoomSize.Text;
            Roomtype.ThisRoomtype.Roomtype = txtRoomType.Text;
            Roomtype.ThisRoomtype.DateTime = Convert.ToDateTime(txtDateAdded.Text);
            //add the record 
            Roomtype.Add();
            //all done so redirect to the main pahgge 
            Response.Redirect("Default.aspx");
        }

        else
        {
            //report Error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
    void Update()
    {
        //create an instance of the Roomtype
        clsRoomtypeCollection Roomtype = new clsRoomtypeCollection();
        //validate the data on the web form 
        String Error = Roomtype.ThisRoomtype.Valid(txtRoomID.Text, txtRoomFloor.Text, txtRoomType.Text, txtRoomType.Text, txtDateAdded.Text);
        //if the data is OK then add it to the subject 
        if (Error == "")
        {
            //find the record to update
            Roomtype.ThisRoomtype.Find(RoomtypeID);
            Roomtype.ThisRoomtype.RoomtypeID = Convert.ToInt32(txtRoomID.Text);
            Roomtype.ThisRoomtype.RoomFloorNo = Convert.ToInt32(txtRoomFloor.Text);
            Roomtype.ThisRoomtype.RoomtypeSize = txtRoomSize.Text;
            Roomtype.ThisRoomtype.Roomtype = txtRoomType.Text;
            Roomtype.ThisRoomtype.DateTime = Convert.ToDateTime(txtDateAdded.Text);
            //update the record 
            Roomtype.Update();
            //all done so redirect back to the main page 
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the dat entered" + Error;
        }
    }
    void DisplayRoomtype()
    {
        //Create an instance of the class we want to create 
        clsRoomtypeCollection Roomtype = new clsRoomtypeCollection();
        //find the record to update
        Roomtype.ThisRoomtype.Find(RoomtypeID);
        //display the data for this record 
        txtRoomID.Text = Roomtype.ThisRoomtype.RoomtypeID.ToString();
        txtRoomFloor.Text = Roomtype.ThisRoomtype.RoomFloorNo.ToString();
        txtRoomSize.Text = Roomtype.ThisRoomtype.RoomtypeSize;
        txtRoomType.Text = Roomtype.ThisRoomtype.Roomtype;
        txtDateAdded.Text = Roomtype.ThisRoomtype.DateTime.ToString();

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }

    protected void txtDateAdded_TextChanged(object sender, EventArgs e)
    {

    }
}