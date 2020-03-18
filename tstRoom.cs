using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


namespace RoomtypeTesting
{
    [TestClass]
    public class tstRoom
    {
        
        string RoomtypeFloorNo = "1";
        string RoomtypeSize = "4 Guests";
        string Roomtype = "Standard";
        string Datetime = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomType = new clsRoomType();
            //test to see that it exists
            Assert.IsNotNull(ARoomType);
        }
        [TestMethod]

        public void RoomTypeIDPropertyOK()
        {
            clsRoomType AnRoomtypeID = new clsRoomType();
            //create some test data to assignto the property 
            Int32 TestData = 81;
            //assign the data to the property
            AnRoomtypeID.RoomtypeID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnRoomtypeID.RoomtypeID, TestData);
        }
        [TestMethod]
        public void RoomtypeFloorNoPropertyOK()
        {
            clsRoomType AnFloorNo = new clsRoomType();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            AnFloorNo.RoomFloorNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFloorNo.RoomFloorNo, TestData);
        }
        [TestMethod]
        public void RoomtypeSizePropertyOK()
        {
            clsRoomType AnRoomTypeSize = new clsRoomType();
            //create some test data to assign to the property 
            String TestData = "4 Guests";
            //assign the data to the property 
            AnRoomTypeSize.RoomtypeSize = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnRoomTypeSize.RoomtypeSize, TestData);
        }
        [TestMethod]
        public void RoomtypePropertyOK()
        {
            clsRoomType AnRoomtype = new clsRoomType();
            //create some test data to assign to the property 
            String TestData = "Standard";
            //assign the data to the property 
            AnRoomtype.Roomtype = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnRoomtype.Roomtype, TestData);
        }
        [TestMethod]
        public void DataAddedPropertyOK()
        {
            clsRoomType AnRoomType = new clsRoomType();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnRoomType.DateTime = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnRoomType.DateTime, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 RoomtypeID = 81;
            //invoke method 
            Found = ARoomtype.Find(RoomtypeID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestRoomtypeIDFound()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 RoomtypeID = 81;
            //invoke method 
            Found = ARoomtype.Find(RoomtypeID);
            //check the RoomypeID
            if (ARoomtype.RoomtypeID != 81)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRoomFloorNoFound()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 RoomtypeID = 81;
            //invoke method 
            Found = ARoomtype.Find(RoomtypeID);
            //check the RoomypeID
            if (ARoomtype.RoomFloorNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestRoomtypeSizeFound()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 RoomtypeID = 81;
            //invoke method 
            Found = ARoomtype.Find(RoomtypeID);
            //check the RoomypeID
            if (ARoomtype.RoomtypeSize != "4 guests")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestRoomtypeFound()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 RoomtypeID = 81;
            //invoke method 
            Found = ARoomtype.Find(RoomtypeID);
            //check the RoomypeID
            if (ARoomtype.Roomtype != "Standard")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 RoomtypeID = 81;
            //invoke method 
            Found = ARoomtype.Find(RoomtypeID);
            //check the RoomypeID
            if (ARoomtype.DateTime != Convert.ToDateTime("12/03/2020"))
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
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store the error message 
            String Error = "";
            //invoke method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoMinLessOne()
        {
            //create an instnce of the class we want to creatr
            clsRoomType ARoomtype = new clsRoomType();
            //string variabble to store the error message 
            String Error = "";
            //create some test data to pass the method 
            string RoomtypeFloorNo = "";
            //invoke method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void RoomtypeFloorNoMin()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string RoomtypeFloorNo = "a";
            //invoke the method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that he results are correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeFloorNo = "aaaaaa";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeFloorNo = "";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(49, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoMax()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeFloorNo = "";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(50, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoMid()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeFloorNo = "";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(25, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeFloorNo = "";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(51, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeFloorNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeFloorNo = "aaaaa";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(500, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeExtremeMin()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create variable to store test data 
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatver is the date ess 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable 
            string Datetime = TestDate.ToString();
            //invoke the method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeSizeMinLessOne()
        {
            //create an instnce of the class we want to creatr
            clsRoomType ARoomtype = new clsRoomType();
            //string variabble to store the error message 
            String Error = "";
            //create some test data to pass the method 
            string RoomtypeSize = "aaa";
            //invoke method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void RoomtypeSizeMin()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string RoomtypeSize = "a";
            //invoke the method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that he results are correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeSizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeSize = "a";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeSizeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeSize = "a";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeSizeMax()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaaaaaa";
            //create some test data to pass to the method
            string RoomtypeSize = "a";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeSizeMid()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeSize = "aaa";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeSizeExtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeSize = "aa";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(500, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeMinLessOne()
        {
            //create an instnce of the class we want to creatr
            clsRoomType ARoomtype = new clsRoomType();
            //string variabble to store the error message 
            String Error = "";
            //create some test data to pass the method 
            string Roomtype = "aaaa";
            //invoke method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void RoomtypeMin()
        {
            //create an instance of the class we want to create 
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string Roomtype = "a";
            //invoke the method 
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that he results are correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomtypeSize = "a";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Roomtype = "a";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeMax()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaaaaaa";
            //create some test data to pass to the method
            string Roomtype = "a";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeMid()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Roomtype = "aaa";
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomtypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomtype = new clsRoomType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Roomtype = "";
            RoomtypeFloorNo = RoomtypeFloorNo.PadRight(500, 'a');
            //invoke the method
            Error = ARoomtype.Valid(RoomtypeFloorNo, RoomtypeSize, Roomtype, Datetime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
    
}
