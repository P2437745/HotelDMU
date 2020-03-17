using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDelete : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the text box txtCustomerID
        CustomerID =   Convert.ToInt32(Request.QueryString["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        ///this function handles the click event of the Yes button

        //create an instance of the class clsCustomerNameCollection called ThisCustomer
        clsCustomerNameCollection CustomerSignUp = new clsCustomerNameCollection();
        //declear a boolean variable for Found
        Boolean Found;
        //try and find the record to delete
        Found = CustomerSignUp.ThisCustomer.Find(CustomerID);
        //if the record is found
        if (Found)
        {
            //invoke the delete method of the object
            CustomerSignUp.Delete();
        }
        Response.Redirect("CustomerDefault.aspx");
    }
   


    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDefault.aspx");
    }
}