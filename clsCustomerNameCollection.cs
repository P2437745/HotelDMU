using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCustomerNameCollection
/// </summary>
public class clsCustomerNameCollection
{
    clsDataConnection dataConnection = new clsDataConnection(); //create a connection to the database
    //member var for currrent customer
    clsCustomers mThisCustomer = new clsCustomers();

    public clsCustomerNameCollection()
    {
        dataConnection = new clsDataConnection();
        dataConnection.AddParameter("@SureName", "");//send a surename filter to the query
        dataConnection.Execute("sproc_tblCustomers_FilterBySureName");//execute the query
    }

    public Boolean Delete()
    {
        ///this public funciton provides the functionality for the delete method
        try //try to delete the record 
        {
            //create an instance of the data connection class called CustomerID
            clsDataConnection MyDatabase = new clsDataConnection();
            //add the PlayerNo parameter passed  to this function to the list of parameters to use in the database
            MyDatabase.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure in the database
            MyDatabase.Execute("sproc_tblCustomers_Delete");
            //set the return value for the function
            return true;

        }
        catch//do this only if the code above failed for some reason
        {
            //report back that there was an error
            return false;
        }
    }

    public List<clsCustomers> CustomerList
    {
        get
        {

            //create an array list of type clsCustomers
            List<clsCustomers> mCustomerList = new List<clsCustomers>(); //create an arry list of type clsCustomers
            //declear variables for each field in the table
            Int32 CustomerID;
            string FirstName;
            string SureName;
            string Address;
            string Email;
            Int32 PhoneNumber;
            DateTime DateTime;
            Int32 RecordCount;  //var to store the count of records
            //public read only property for the count of records found
            Int32 Index = 0; //var to store the index for the loop
            //declear a variable fo the primary key vlaue
            //Int32 CustomerID;
            //create a connection to the database
            //dataConnection = new clsDataConnection();
            //dataConnection.AddParameter("@SureName", "");//send a surename filter to the query
            //dataConnection.Execute("sproc_tblCustomers_FilterBySureName");//execute the query
            //get the count of records
            RecordCount = dataConnection.Count;//get the primary key value for the first record
            CustomerID = Convert.ToInt32(dataConnection.DataTable.Rows[0]["CustomerID"]);
            while (Index < RecordCount) //keep looping till all records are processed
            {
                //create a blank Customer page
                clsCustomers NewCustomer = new clsCustomers();
                //copy the data from the table to the RAM
                NewCustomer.CustomerID = Convert.ToInt32(dataConnection.DataTable.Rows[Index]["CustomerID"]);
                NewCustomer.FirstName = Convert.ToString(dataConnection.DataTable.Rows[Index]["FirstName"]);
                NewCustomer.SureName = Convert.ToString(dataConnection.DataTable.Rows[Index]["SureName"]);
                NewCustomer.Address = Convert.ToString(dataConnection.DataTable.Rows[Index]["Address"]);
                NewCustomer.Email = Convert.ToString(dataConnection.DataTable.Rows[Index]["Email"]);
                NewCustomer.PhoneNumber = Convert.ToString(dataConnection.DataTable.Rows[Index]["PhoneNumber"]);
                NewCustomer.DateOfBirth = Convert.ToDateTime(dataConnection.DataTable.Rows[Index]["DateTime"]);
                mCustomerList.Add(NewCustomer);
                //increase the index
                Index++;
            }
            //return the list as the return value of the function
            return mCustomerList;
        }


    }

    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
            //create a connection to the database
            //dataConnection = new clsDataConnection();
            //send a surename filter to the query
            //dataConnection.AddParameter("@SureName", "");
            //execute teh query
            //dataConnection.Execute("sproc_tblCustomers_FilterBySureName");
            //get the count of records
            return dataConnection.Count;
        }

    }


    public Int32 Add()
    ///this function will add a new customer to the database
    ///it accepts a single parameter an object of type clscustomers
    ///once the record is added the function returns the primary key value of the new record
    ///                ///
    ///Insert INTO tblCustomers
    // (FirstName, SureName, Address, Email, PhoneNumber, DateTime)
    //SELECT
    // @FirstName, @SureName, @Address, @Email, @PhoneNumber, @DateTime;

    {

        //connect to the database
        clsDataConnection NewCustomerDB = new clsDataConnection();
        //add the parameters
        NewCustomerDB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
        NewCustomerDB.AddParameter("@FirstName", mThisCustomer.FirstName);
        NewCustomerDB.AddParameter("@SureName", mThisCustomer.SureName);
        NewCustomerDB.AddParameter("@Address", mThisCustomer.Address);
        NewCustomerDB.AddParameter("@Email", mThisCustomer.Email);
        NewCustomerDB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
        NewCustomerDB.AddParameter("@DateTime", mThisCustomer.DateOfBirth);
        //execute the stored porcedure returning the primary key value of the new record
        return NewCustomerDB.Execute("sproc_tblCustomers_Insert");
    }
    public void Update()
    {
        ///this function will update an existing Jersey in the database
        ///it accepts a single parameter an object of type clsNBAJereys
        ///the JerseyID property must have a valid value for this to work
        ///SET FirstName = @FirstName,
        ///    SureName = @SureName,
        ///    Address = @Address,
        ///    Email = @Email,
        ///    PhoneNumber = @PhoneNumber,
        ///    DateTime = @DateTime,
        //--where the CustomerID matches the value of @CustomerID passed as the parameter 
        //WHERE CustomerID=@CustomerID;       {
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //add the parameters
        DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
        DB.AddParameter("@FirstName", mThisCustomer.FirstName);
        DB.AddParameter("@SureName", mThisCustomer.SureName);
        DB.AddParameter("@Address", mThisCustomer.Address);
        DB.AddParameter("@Email", mThisCustomer.Email);
        DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
        DB.AddParameter("@DateTime", mThisCustomer.DateOfBirth);
        //execute the query 
        DB.Execute("sproc_tblCustomers_Update");
    }

    //this function defines the ReportBySureName method
    public void ReportBySureName(string SureName)
    {
        //create a connection to the database
        dataConnection = new clsDataConnection();
        //send a customer filter to the query
        dataConnection.AddParameter("@SureName", SureName);
        //execute the query
        dataConnection.Execute("sproc_tblCustomers_FilterBySureName");
    }

    //public ThisCustomer property
    public clsCustomers ThisCustomer
    {
        get
        {

            return mThisCustomer;
        }
        set
        {
            mThisCustomer = value;
        }
    }
}








