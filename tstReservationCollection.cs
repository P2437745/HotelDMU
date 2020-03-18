using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class tstReservationCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to change
            clsReservationCollection AnReservation = new clsReservationCollection();
            //test to see if it exists
            Assert.IsNotNull(AnReservation);
        }

        [TestMethod]
        public void ReservationListOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsReservation> TestList = new List<clsReservation>();
            //add an item to the list 
            //create the item of test data 
            clsReservation TestItem = new clsReservation();
            //set it properties
            TestItem.Active = true;
            TestItem.ReservationID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.DueDate = DateTime.Now;
            TestItem.CancelationFee = 100;
            TestItem.RoomCost = 200;
            TestItem.NumberAdult = 1;
            TestItem.NumberChild = 1;
            TestItem.NumberRoom = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign teh data to the property
            AllReservation.ReservationList = TestList;
            Assert.AreEqual(AllReservation.ReservationList, TestList);
            //generate property 



        }


        [TestMethod]

        public void CountReservationOK()
        {
            //create an instance of the class we want to create
            clsReservationCollection AllReservation = new clsReservationCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 2;
            //Assign the data to the property 
            AllReservation.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllReservation.Count, SomeCount);
        }



        [TestMethod]
        public void ThisReservationPropertyOK()
        {
            //create an instance of the class we want to create 
            clsReservationCollection AllReservation = new clsReservationCollection();
            //create some test data to assign to the property 
            clsReservation TestReservation = new clsReservation();
            //set the properties of the test object 
            TestReservation.Active = true;
            TestReservation.ReservationID = 1;
            TestReservation.CancelationFee = 100;
            TestReservation.DateAdded = DateTime.Now;
            TestReservation.DueDate = DateTime.Now;
            TestReservation.RoomCost = 200;
            TestReservation.NumberAdult = 1;
            TestReservation.NumberChild = 1;
            TestReservation.NumberRoom = 1;
            //assign the data to the property 
            AllReservation.ThisReservation = TestReservation;
            //test to see that the two values are the same 
            Assert.AreEqual(AllReservation.ThisReservation, TestReservation);


        }


        [TestMethod]
        public void ListAndCount()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsReservation> TestList = new List<clsReservation>();
            //add an item to the list 
            //create the item of test data 
            clsReservation TestItem = new clsReservation();
            //set it properties
            TestItem.Active = true;
            TestItem.ReservationID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.DueDate = DateTime.Now;
            TestItem.CancelationFee = 100;
            TestItem.RoomCost = 200;
            TestItem.NumberAdult = 1;
            TestItem.NumberChild = 1;
            TestItem.NumberRoom = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign teh data to the property
            AllReservation.ReservationList = TestList;
            Assert.AreEqual(AllReservation.ReservationList, TestList);
            //generate property 



        }




        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create 
            clsReservationCollection AllReservation = new clsReservationCollection();
            //create the item of test data
            clsReservation TestItem = new clsReservation();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it properties
            TestItem.Active = true;
            TestItem.ReservationID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.DueDate = DateTime.Now;
            TestItem.CancelationFee = 100;
            TestItem.RoomCost = 200;
            TestItem.NumberAdult = 1;
            TestItem.NumberChild = 1;
            TestItem.NumberRoom = 1;
            //set ThisReservation to the test datas
            AllReservation.ThisReservation = TestItem;
            //add the record
            PrimaryKey = AllReservation.Add();
            // set the primary key of the test data
            TestItem.ReservationID = PrimaryKey;
            //find the record
            AllReservation.ThisReservation.Find(PrimaryKey);
            Assert.AreEqual(AllReservation.ReservationList, TestItem);
            //generate property 



        }


        public class clsReservationCollection
        {

            public List<clsReservation> ReservationList

            {
                get
                {


                }
                set
                {

                }
            }

            public int Count




            public clsReservation ThisReservation { get; internal set; }

            internal int Add()
            {
                throw new NotImplementedException();
            }
        }





    }





}
