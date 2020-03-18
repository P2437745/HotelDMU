using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class tstReservation
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to change
            clsReservation AnReservation = new clsReservation();
            //test to see if it exists
            Assert.IsNotNull(AnReservation);
        }

        [TestMethod]
        public void ActiveReservationOK()
        {
            //create an instance of the class we want to change
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //Asign the data to the property
            AnReservation.Active = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnReservation.Active, TestData);
        }


        [TestMethod]
        public void ReservationDateOK()
        {
            //create an instance of the class we want to change
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //Asign the data to the property
            AnReservation.DateAdded = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnReservation.DateAdded, TestData);
        }




        [TestMethod]
        public void RoomIDOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.RoomID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.RoomID, TestData);
        }

        [TestMethod]
        public void RoomCostOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.RoomCost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.RoomCost, TestData);
        }

        [TestMethod]
        public void ReservationIDOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.ReservationID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.ReservationID, TestData);
        }



        [TestMethod]
        public void CancelationFeeOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.CancelationFee = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.CancelationFee, TestData);
        }

        [TestMethod]
        public void ReservationDueDateOK()
        {
            //create an instance of the class we want to change
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //Asign the data to the property
            AnReservation.DueDate = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnReservation.DueDate, TestData);
        }


        [TestMethod]
        public void NumberAdultOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.NumberAdult = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.NumberAdult, TestData);
        }

        [TestMethod]
        public void NumberChildOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.NumberChild = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.NumberChild, TestData);
        }

        [TestMethod]
        public void NumberRoom()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReservation.NumberRoom = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReservation.NumberRoom, TestData);
        }

        //may have to change 1 to whatever the record id number is 
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ReservationID = 1;
            //invoke method 
            Found = AnReservation.Find(ReservationID);
            //test to tsee that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestReservationNoFound()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReservationID = 21;
            //invoke the method
            Found = AnReservation.Find(ReservationID);
            //check the ReservationID
            if (AnReservation.ReservationID != 12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestReservationDateFound()
        {
            //create an instance of the class we want to change
            clsReservation AnReservation = new clsReservation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            DateTime DateofBrith = Convert.ToDateTime("02/03/2020");
            int ReservationID = 0;
            //invoke the method
            Found = AnReservation.Find(ReservationID);
            //check the property
            if (AnReservation.DateAdded != Convert.ToDateTime("02/03/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeReservation = "Arun";
            //invoke the mehtod
            Error = AnReservation.Valid(SomeReservation);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberAdultsMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberAdults = "a"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, ReservationDueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberAdultsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberAdults = "aa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberAdultsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberAdults = "aa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberAdultsMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberAdults = "aaa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberAdultsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberAdults = "aaaa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void NumberAdultsExtremeMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberAdults = "a"; //this should be ok
            NumberAdults = NumberAdults.PadRight(500, 'a');  //this should fail
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvidualData()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            string DateAdded = "This is not a date";
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }












        [TestMethod]
        public void NumberChildMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "a"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberChildMinPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "aa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberChildMaxLessOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "aa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberChildMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "aaa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberChildPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "aaaa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void NumberChildExtremeMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "a"; //this should be ok
            NumberChild = NumberChild.PadRight(500, 'a');  //this should fail
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }







        [TestMethod]
        public void NumberRoomMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberRoom = "a"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberRoomdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberRoom = "aa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberRoomMaxLessOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberRoom = "a"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberRoomMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberRoom = "aa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberRoomMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "aaaa"; //this should be ok
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void NumberRoomExtremeMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NumberChild = "a"; //this should be ok
            NumberRoom = NumberRoom.PadRight(500, 'a');  //this should fail
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }







        [TestMethod]
        public void DueDatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert data variable to string
            string DueDate = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DueDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert data variable to string
            string DueDate = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DueDateMin()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DueDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DueDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //changin data to date that is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert data variable to string
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DueDateInvidualData()
        {
            //create an instance of the class we want to create
            clsReservation AnReservation = new clsReservation();
            //string variable to store any error message
            String Error = "";
            string DateAdded = "This is not a date";
            //invoke the method
            Error = AnReservation.Valid(NumberAdultOK, NumberChildOK, DueDate, ReservationDateOK, NumberRoom);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




    }

}