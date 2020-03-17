using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCustomers
/// </summary>
public class clsCustomers
{

    clsDataConnection dataConnection = new clsDataConnection(); //create a connection to the database

    //JerseyID Private member variable 
    private Int32 mCustomerID;
    //JerseyID public property
    public Int32 CustomerID
    {
        get
        {
            //this line of code send data out of the property 
            return mCustomerID;
        }
        set
        {
            //this line of code allows data into the property
            mCustomerID = value;
        }

    }

    //CustomerID Private member variable 
    private DateTime mDateOfBirth;
    //CustomerID public property
    public DateTime DateOfBirth
    {
        get
        {
            //this line of code send data out of the property 
            return mDateOfBirth;
        }
        set
        {
            //this line of code allows data into the property
            mDateOfBirth = value;
        }

    }

    //FirstName Private member variable 
    private string mFirstName;
    //FirstName public property
    public string FirstName
    {
        get
        {
            //this line of code send data out of the property 
            return mFirstName;
        }
        set
        {
            //this line of code allows data into the property
            mFirstName = value;
        }


    }

    //SureName private memeber variable
    private string mSureName;
    //SureName public property
    public string SureName
    {
        get
        {
            //this line of code send data out of the property 
            return mSureName;
        }
        set
        {
            //this line of code allows data into the property
            mSureName = value;
        }


    }


    //Conference private memeber variable
    private string mAddress;
    //Confernce public property
    public string Address
    {
        get
        {
            //this line of code send data out of the property 
            return mAddress;
        }
        set
        {
            //this line of code allows data into the property
            mAddress = value;
        }


    }

    //Team private memeber variable
    private string mEmail;
    //Team public property
    public string Email
    {
        get
        {
            //this line of code send data out of the property 
            return mEmail;
        }
        set
        {
            //this line of code allows data into the property
            mEmail = value;
        }


    }

    //PlayerNumber private memeber variable
    private string mPhoneNumber;
    //Confernce public property
    public string PhoneNumber
    {
        get
        {
            //this line of code send data out of the property 
            return mPhoneNumber;
        }
        set
        {
            //this line of code allows data into the property
            mPhoneNumber = value;
        }


    }
    public string Valid(
       string FirstName,
       string SureName,
       string Address,
       string Email,
       String InputDate,
       string PhoneNumber)

    ///this function is used to validate the data in a new address
    /// it accpets six parameter and returns a string containing th etext of the errors (if any)
    /// otherwise of no errors it returns a bkank string
    {

        //string ErrorMsg; //var to store any error message
        //ErrorMsg = ""; //initialise the var with a blank string
        //if the string is less than 1 char or more than 15

        //if (CustomerID.Length < 1 | CustomerID.Length > 15)
        //{

        //    //record an error
        //    ErrorMsg = ErrorMsg + "The player name must be between 1 and 15 characters";
        //}
        ////return any error messaages generated
        //return ErrorMsg;


        //var to store the error message
        string ErrMsg = "";
        //check the min length of the first name
        if (FirstName.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "First Name is blank. ";
        }
        //check the max length of the firstname
        if (FirstName.Length > 16)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "First Name must be less than 16 characters. ";
        }
        //check the min length of the surename
        if (SureName.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Sure Name is blank. ";
        }
        //check the max length of the surename
        if (SureName.Length > 50)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Surename must be less than 50 characters. ";
        }
        //check the min length for the Address
        if (Address.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Address is blank. ";
        }
        //check the max length for the conference
        if (Address.Length > 50)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Town must be less than 50 characters. ";
        }
        //check the min length for the PlayerNumber
        if (PhoneNumber.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Phone Number is blank. ";
        }
        //check the max length for the phone number
        if (PhoneNumber.Length > 12)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Phone number  must be less than 12 characters. ";
        }
        //test if the date is valid
        try//try the operation
        {
            //var to store the date
            DateTime Date;
            //assign the date to the temporary var
            Date = Convert.ToDateTime(InputDate);
        }
        catch//if it failed report an error
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Date added is not valid. ";
        }
        //if there were no errors
        if (ErrMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrMsg;
        }



    }


    //function for the find public method
    public Boolean Find(Int32 CustomerID)
    {
        //initialise the data connection
        dataConnection = new clsDataConnection();
        //add the Jersey no parameter
        dataConnection.AddParameter("@CustomerID", CustomerID);
        //execute the query
        dataConnection.Execute("sproc_tblCustomers_FilterByCustomer");
        //if the record was found
        if (dataConnection.Count == 1)
        {
            //get the JerseyID
            mCustomerID = Convert.ToInt32(dataConnection.DataTable.Rows[0]["CustomerID"]);
            mFirstName = Convert.ToString(dataConnection.DataTable.Rows[0]["FirstName"]);
            mSureName = Convert.ToString(dataConnection.DataTable.Rows[0]["SureName"]);
            mAddress = Convert.ToString(dataConnection.DataTable.Rows[0]["Address"]);
            mEmail = Convert.ToString(dataConnection.DataTable.Rows[0]["Email"]);
            mPhoneNumber = Convert.ToString(dataConnection.DataTable.Rows[0]["PhoneNumber"]);
            mDateOfBirth = Convert.ToDateTime(dataConnection.DataTable.Rows[0]["DateTime"]);

            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }
    }

    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {

            //get the count of records
            return dataConnection.Count;
        }

    }



}