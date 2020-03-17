using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyUnitTestProject
{
    [TestClass]
    public class tstCustomers
    {
        public int CustomerID { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            // test to see that it exist
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the proprty
            string SomeCustomer = "Sonny";
            //assign the data to the property
            AnCustomer.FirstName = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, SomeCustomer);
        }

        [TestMethod]
        public void CustomerSureNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the proprty
            string SomeCustomer = "Sahota";
            //assign the data to the property
            AnCustomer.FirstName = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, SomeCustomer);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()
        {
            //cerate an instance of the class we want to creat
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            string CustomerPhoneNumber = "074685";
            //assign the data to the property
            AnCustomer.PhoneNumber = CustomerPhoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, CustomerPhoneNumber);
        }

        [TestMethod]
        public void CustomerEmailpropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the proprty
            string SomeCustomer = "p2442077@my365.dmu.ac.uk";
            //assign the data to the property
            AnCustomer.Email = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, SomeCustomer);
        }

        [TestMethod]
        public void CustomerAddresspropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the proprty
            string SomeCustomer = "3 Avenue road";
            //assign the data to the property
            AnCustomer.Address = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, SomeCustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //cerate an instance of the class we want to creat
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            Int32 CustomerID = 1;
            //assign the data to the property
            AnCustomer.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, CustomerID);
        }

        //[TestMethod]
        //public void ValidMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "Sonny";
        //    //invoke the mehtod
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the result is OK i.e there was no error message returned
        //    Assert.AreEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerFirstNameMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerFirstNameMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerFirstNameMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerFirstNameMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerFirstNameMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerFirstNameMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void CustomerIDMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerIDMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerIDMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerIDMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerIDMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerIDMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}
        //[TestMethod]
        //public void CustomerSureNameMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerSureNameMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerSureNameMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerSureNameMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerSureNameMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerSureNameMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}


        //[TestMethod]
        //public void CustomerPhoneNumberMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerPhoneNumberMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerPhoneNumberMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerPhoneNumberMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerPhoneNumberMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerPhoneNumberMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}


        //[TestMethod]
        //public void CustomerAddressMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerAddressMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerAddressMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerAddressMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerAddressMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerAddressMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}


        //[TestMethod]
        //public void CustomerEmailMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerEmailMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerEmailMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerEmailMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerEmaileMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerEmailMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}


        //[TestMethod]
        //public void CustomerDateTimeMinLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerDateTimeMinBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerDateTimeMinPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerDateTimeMaxLessOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerDateTimeMaxBoundary()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");

        //}

        //[TestMethod]
        //public void CustomerDateTimeMaxPlusOne()
        //{
        //    //create an instance of the class that we want to create
        //    clsCustomers AnCustomer = new clsCustomers();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeCustomer = "";
        //    //invoke the method
        //    Error = AnCustomer.Valid(SomeCustomer);
        //    //test to see that the resul is NOT OK i.e there should be an error message
        //    Assert.AreNotEqual(Error, "");
        //}

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke method 
            Found = AnCustomer.Find(CustomerID);
            //test to tsee that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 12;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customerID
            if (AnCustomer.CustomerID != 12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "07464865";
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "3 Avenue Road";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void TestDateTimeFound()
        {
            //create an instance of the class we want to create
            clsCustomers AnCustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            DateTime DateofBrith = Convert.ToDateTime("16/09/2015");
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }

}
          
  
