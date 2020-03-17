using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyUnitTestProject
{
    [TestClass]
    public class tstCustomerNameCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerNameCollection AllCustomers = new clsCustomerNameCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerNameCollection AllCustomers = new clsCustomerNameCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the daata to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomersOK()
        {
            //create an instance of the class we want to create
            clsCustomerNameCollection Customers = new clsCustomerNameCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Sonny";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsCustomerNameCollection Customers = new clsCustomerNameCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Sonny";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.Count, TestList.Count);
        }
        public class clsCustomerNameCollection
        {
            //private data member for the allCustomers liist
            private List<clsCustomers> mAllCustomers = new List<clsCustomers>();

            //public property for count
            public int Count
            {
                get
                {
                    //return the count property of the private list 
                    return mAllCustomers.Count;
                }
                set
                {
                    //we will look at this in a moment!                
                }
            }



            //public property for allCustomers
            public List<clsCustomers> AllCustomers
            {
                //getter sends data to requesting code
                get
                {

                    //return the private data member 
                    return mAllCustomers;
                }

                //setter accepts data from other objects
                set
                {
                    //assign the incoming value to the private data member
                    mAllCustomers = value;
                }
            }

            public List<clsCustomers> CustomerList { get; private set; }

            [TestMethod]
            public void CustomerListOK()
            {
                //create an instance of the class we want to create
                clsCustomerNameCollection AllCustomers = new clsCustomerNameCollection();
                //create some test data to assign to the property
                //in this case that data needs to be a list of objects
                List<clsCustomers> TestList = new List<clsCustomers>();
                //add an item of test data
                clsCustomers TestItem = new clsCustomers();
                //set its properties
                TestItem.FirstName = "SomeName";
                TestItem.CustomerID = 1;
                //add the item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllCustomers.CustomerList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllCustomers.CustomerList, TestList);
            }

            [TestMethod]
            public void TwoCustomersPresent()
            {
                //create an instance of the class we want to create
                clsCustomerNameCollection Customers = new clsCustomerNameCollection();
                //test to see that the two values are the same
                Assert.AreEqual(Customers.Count, 2);
            }

            //public constructor for the class
            public clsCustomerNameCollection()
            {
                //create an instance of the customer class to store a customer
                clsCustomers ACustomer = new clsCustomers();
                //set the customer to sonny
                ACustomer.FirstName = "Sonny";
                //add the customer to the private list of customers
                mAllCustomers.Add(ACustomer);
                //re intialise the ACustomer object to accept a new item
                ACustomer = new clsCustomers();
                //set the customer to Radhe
                ACustomer.FirstName = "Radhe";
                //add the second customer to the private list of customers
                mAllCustomers.Add(ACustomer);
                //the private list now contains two customers
            }


        }

    }

}
