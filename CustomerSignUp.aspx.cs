using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerSignUp : System.Web.UI.Page
{
    //var to store the CustomerID
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //var to store the Customer
        //Int32 CustomerID;
        //copy the data from the query string to the text box
        CustomerID = Convert.ToInt32(Request.QueryString["CustomerID"]);
        //if this is not an instruction to add a new record
        if (CustomerID != -1)
        {
            if (IsPostBack != true)

            {
                //display the existing data
                DisplayCustomers(CustomerID);  
            }


        }
    }

    //this function displays the data for an Customer on the web form
    void DisplayCustomers(Int32 CustomerID)

    {
        //create an instance of the Customer class           
        clsCustomers Customers = new clsCustomers();

        //find the record we want to display
        Customers.Find(CustomerID);
        //display Customer first name
        txtFirstName.Text = Customers.FirstName;
        //display Customer surename
        txtSureName.Text = Customers.SureName;
        //display Customer address 
        txtAddress.Text = Customers.Address;
        //diplay Customer phone number
        txtPhoneNumber.Text = Convert.ToString(txtPhoneNumber.Text);
        //display Customer email
        txtEmail.Text = Customers.Email; 
        //disaply the date of birth 
        txtDateOfBirth.Text = Customers.DateOfBirth + "/" + Customers.DateOfBirth.Month + "/" + Customers.DateOfBirth.Year;

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        {
            //create an instance of the clscustomers page calss
            clsCustomers ThisCustomer = new clsCustomers();
            //var to store any error message
            string ErrorMessage = "";
            //if there is no error message
            if (ErrorMessage == "")
            {
                //create a new instance of the Customer class
                clsCustomerNameCollection Customer = new clsCustomerNameCollection();
                //do something with the data - insert or update 
                //
                //if the customerID  is -1
                if (CustomerID == -1)
                {
                    //copy the data from the interface to the object
                    Customer.ThisCustomer.FirstName = txtFirstName.Text;
                    Customer.ThisCustomer.SureName = txtSureName.Text;
                    Customer.ThisCustomer.Address = txtAddress.Text;
                    Customer.ThisCustomer.Email = txtEmail.Text;
                    Customer.ThisCustomer.PhoneNumber = Convert.ToString(txtPhoneNumber.Text);
                    Customer.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                    //add the new record
                    Customer.Add();
                }
                else
                {


                    //this is an existing record
                    //copy the data from the interface to the object
                    Customer.ThisCustomer.CustomerID = Convert.ToInt32(CustomerID);
                    Customer.ThisCustomer.FirstName = txtFirstName.Text;
                    Customer.ThisCustomer.SureName = txtSureName.Text;
                    Customer.ThisCustomer.Address = txtAddress.Text;
                    Customer.ThisCustomer.Email = txtEmail.Text;
                    Customer.ThisCustomer.PhoneNumber = Convert.ToString(txtPhoneNumber.Text);
                    Customer.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

                    //update the existing record
                    Customer.Update();
                }


                //redirect back to the main page
                Response.Redirect("CustomerDefault.aspx");
            }
            else
            {
                //dispaly the error message
                lblError.Text = ErrorMessage;
            }
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("CustomerDefault.aspx");
    }

    
}
