using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AnReservation : System.Web.UI.Page
{
    Int32 ReservationID;
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            ReservationID = Convert.ToInt32(Request.QueryString["ReservationID"]);
            //if this function handles the load event for the page
            if (ReservationID != -1)
            {
                if (IsPostBack != true)

                {
                    //display the existing data
                    DisplayReservation(ReservationID);
                }


            }



        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtContinue_Click(object sender, EventArgs e)
    {
        //create an instance of the Reservation class           
        clsReservationCollection Reservation = new clsReservationCollection();
        //validate the data on the web form 
        string Error = "";
        //if the data is OK then add it to the object
        if (Error == "")
        {



            //get the datis OK then add it to the object

            Reservation.ThisReservation.DueDate = Convert.ToDateTime(txtDueDate.Text);
            Reservation.ThisReservation.NoAdults = Convert.ToInt32(txtNoAdults.Text);
            Reservation.ThisReservation.NoChildren = Convert.ToInt32(txtNoChildren.Text);
            Reservation.ThisReservation.NoRooms = Convert.ToInt32(txtNoRooms.Text);
            Reservation.ThisReservation.Date = Convert.ToDateTime(txtDate.Text);
            //add the record
            Reservation.Update();
            //all done so riderect back to the main page
            Response.Redirect("ReservationDefault.aspx");
        }




        else
        {
            //report an error
            lblError.Text = "there was a problem with what you entered" + Error;
        }


    }


    public void Delete()
    {
        //delete the record pointed to by thisReservation
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //set the parameters for the stored procedure
        //execute the stored procedure
        //  DB.Execute("sproc_tblReservation_Delete");

    }



    void DisplayReservation(Int32 ReservationID)
    {
        //create an instance of the county collection
        clsReservation Reservation = new clsReservation();

        //find the record to update
        Reservation.ThisReservation.Find(ReservationID);
        //display the data for this record
        txtDate.Text = Reservation.ThisReservation.Date;
        txtDueDate.Text = Reservation.ThisReservation.DueDate;
        txtNoChildren.Text = Reservation.ThisReservation.NoChildren;
        txtNoRooms.Text = Reservation.ThisReservation.NoRooms;
        txtReservationID.Text = Reservation.ThisReservation.Name;
        txtNoAdults.Text = Reservation.ThisReservation.NoAduts;


    }

    protected void txtClear_Click(object sender, EventArgs e)
    {

    }
}