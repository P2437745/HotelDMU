using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        public string Customer { get; set; }
        public int CustomerID { get; set; }



        public string Valid(string someCustomer)
        {

            //string variable to store the error message
            string Error = "";
            //if the name of the customer is more than 50 characters
            if (someCustomer.Length > 50)
            {
                // return an error message
                Error = "The customer name cannot have more than 50 characters";
            }
            if (someCustomer.Length == 0)
            {
                //return an error message
                Error = "The customer name may not be blank!";
            }
            return Error;
        }
    }

}

