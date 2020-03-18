using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 ReservationID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the text box txtReservation
        ReservationID = Convert.ToInt32(Request.QueryString["ReservationID"]);
    }


    void DeleteReservation()
    {
        //function to delete the selected record

        clsReservationCollection Reservation = new clsReservationCollection();
        //find the record to delete
        Reservation.ThisReservation.Find(ReservationID);
        //delete teh record 
        Reservation.Delete();

    }





    protected void btnDeleteYes_Click(object sender, EventArgs e)
    {
        DeleteReservation();
        //redirect back to maiin page
        Response.Redirect("ReservationDefault.aspx");


    }

    protected void btnDeleteNo_Click(object sender, EventArgs e)
    {

    }
}