using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyUnitTestProject
{
    [TestClass]
    public class tstCustomerCollection
    {
        private List<clsCustomers> mCustomerList;

        public object TestCustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.FirstName = "Sonny";
            TestItem.SureName = "Sahota";
            TestItem.CustomerID = 1;
            TestItem.Address = "12 Avenue Road";
            TestItem.Email = "p2442077@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "09944886633";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create 
        //    clsCustomerNameCollection AllCustomers = new clsCustomerNameCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 0;
        //    //assign the daata to the property
        //    AllCustomers.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomers TestItem = new clsCustomers();
            //set the properties of the test object
            TestItem.FirstName = "Sonny";
            TestItem.SureName = "Sahota";
            TestItem.CustomerID = 1;
            TestItem.Address = "12 Avenue Road";
            TestItem.Email = "p2442077@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "09944886633";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {

            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.FirstName = "Sonny";
            TestItem.SureName = "Sahota";
            TestItem.CustomerID = 1;
            TestItem.Address = "12 Avenue Road";
            TestItem.Email = "p2442077@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "09944886633";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        public class clsCustomerCollection
        {
            //private data member for the list
            List<clsCustomers> mCustomerList = new List<clsCustomers>();

            public List<clsCustomers> CustomerList { get; internal set; }
            public int Count { get; internal set; }
            public object ThisCustomer { get; internal set; }
        }

        //public property for the customer list
        public List<clsCustomers> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }

        }

        //public property for count
        public int count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }



    }
}
