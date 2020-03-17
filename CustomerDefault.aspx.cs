using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class CustomerDefault : System.Web.UI.Page
{
    //var to store the CustomerID
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //var to store the variable
        //copy the data from the query string to the text box txtJerseyID
        CustomerID = Convert.ToInt32(Request.QueryString["CustomerID"]);

        if (CustomerID != -1)
        {
            if (IsPostBack == false)

                //display all Customer
                DisplayCustomers("");
        }
    }
 
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //redirect to the add new page
        Response.Redirect("CustomerSignUp.aspx?CustomerID=-1");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
            if (ListBoxCustomers.SelectedIndex != -1)
            {
                //get the primary key value from the list box
                CustomerID = Convert.ToInt32(ListBoxCustomers.SelectedValue);
                //redirect to the editing page
                Response.Redirect("CustomerDelete.aspx?CustomerID=" + CustomerID);
        }
            else
            {
                //display an error
                lblError.Text = "You must select name on the list first to delete it.";
            }

    }
   

        protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        //check the list has been clicked first 
          
        if (ListBoxCustomers.SelectedIndex != -1)
        {

            //get the primary key value from the list box
            CustomerID = Convert.ToInt32(ListBoxCustomers.SelectedValue);
            //redirect to the editing page
            Response.Redirect("CustomerSignUp.aspx?CustomerID=" + CustomerID);
        }
        else
        {
            //display an error
            lblError.Text = "You must select a name on the list first to edit it.";
        }

    }

    protected void btnDispalyAll_Click(object sender, EventArgs e)
    {
        {
            //display all Customers  Customers
            DisplayCustomers("");
        }
    }
    

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayCustomers(txtCustomers.Text);
    }

    Int32 DisplayCustomers(String SureNameFilter)
    {
        Int32 CustomerID;
        string FirstName;//var to store the first name
        string SureName;//var to store the sure name
        //create an instance of the customer name collection
        clsCustomerNameCollection Customers = new clsCustomerNameCollection();
        Customers.ReportBySureName(SureNameFilter);
        Int32 RecordCount;//var to store the count of records
        Int32 Index = 0;//var to store teh index for the loop
        RecordCount = Customers.Count;//get the count of records
        ListBoxCustomers.Items.Clear();
        while (Index < RecordCount)//while there are records to process
        {

            CustomerID = Customers.CustomerList[Index].CustomerID;//get the primary key
            FirstName = Customers.CustomerList[Index].FirstName;//get the first name 
            SureName = Customers.CustomerList[Index].SureName;//get the first name
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(FirstName + "" + SureName, CustomerID.ToString());
            ListBoxCustomers.Items.Add(NewEntry);//add the address to the list                                   
            Index++;//move the index to the next record
        }
        return RecordCount;//return the count of records found


    }
}