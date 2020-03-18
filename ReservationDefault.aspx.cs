using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    Int32 ReservationID;
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this function handles the load event for the page
        ReservationID = Convert.ToInt32(Session["ReservationID"]);
        if (ReservationID != -1)
        {

            //if this is not a new record
            if (IsPostBack == false)
            {
                //display the current data for the record
                DisplayReservation("");
            }


        }



    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this a new record
        Session["ReservationID"] = -1;
        //this line redirects to the Reservation page
        Response.Redirect("AnReservation.aspx");
    }







    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //display all Reservations
        DisplayReservation("");

    }








    protected void Apply_Click(object sender, EventArgs e)
    {
        DisplayReservation(txtReservasion.Text);
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ReservationID;
        //if a record has been selected fom the list 
        if (lstReservation.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            ReservationID = Convert.ToInt32(lstReservation.SelectedValue);
            //store the data in teh session object 
            Session["ReservationID"] = ReservationID;


        }
        else //if no record is selected
        {
            //display an Error 
            lblError1.Text = "You must select a name on the list first to edit ";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ReservationID;
        //if a record has been selected from the list
        if (lstReservation.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ReservationID = Convert.ToInt32(lstReservation.SelectedValue);
            //store the data in the session object
            Session["ReservationID"] = ReservationID;
            //redirect to the edit page
            Response.Redirect("AnReservation.aspx");

        }
        else   //display if no record is selected
        {
            //display an error
            lblError1.Text = "Please select a record to delete from the list";

        }



    }


    void DisplayReservation(string v)

    {
        //create instance of the class we want to create 
        clsReservationCollection Reservation = new clsReservationCollection();
        //set the data to source the list of roomtype in the collection
        lstReservation.DataSource = Reservation.ReservationList;
        //set the name of the primary key
        lstReservation.DataValueField = "ReservationID";
        //set the data field to display
        lstReservation.DataTextField = "Reservation";
        //blind the data to the list
        lstReservation.DataBind();



    }

}
