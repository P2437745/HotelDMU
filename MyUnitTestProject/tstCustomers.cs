using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyUnitTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // test to see that it exist
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the proprty
            string SomeCustomer = "Sonny";
            //assign the data to the property
            AnCustomer.Customer = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Customer, SomeCustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //cerate an instance of the class we want to creat
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 CustomerID = 1;
            //assign the data to the property
            AnCustomer.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, CustomerID);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "Sonny";
            //invoke the mehtod
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerMinLessOne()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerMinBoundary()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerMinPlusOne()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerMaxLessOne()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerMaxBoundary()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerMaxPlusOne()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomer = "";
            //invoke the method
            Error = AnCustomer.Valid(SomeCustomer);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }
    }

}
