using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace RoomtypeTesting
{
    [TestClass]
    public class tstRoomtypeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllRooms);
        }
        [TestMethod]
        public void RoomTypeListOK()
        {
            //create an instance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsRoomType> TestList = new List<clsRoomType>();
            //add an item to the list 
            //create the item of test data 
            clsRoomType TestItem = new clsRoomType();
            //set its properties 
            TestItem.Active = true;
            TestItem.RoomtypeID = 81;
            TestItem.RoomFloorNo = 1;
            TestItem.RoomtypeSize = "4 guests";
            TestItem.Roomtype = "Standard";
            TestItem.DateTime = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);//assign the data to the property
            AllRooms.RoomtypeList = TestList;
            //test to see that the two valuies are the same 
            Assert.AreEqual(AllRooms.RoomtypeList, TestList);
        }

        [TestMethod]
        public void ThisRoomtypePropertyOK()
        {
            //create an instance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //vreate some test dat to assign to the property 
            clsRoomType TestRooms = new clsRoomType();
            //set the properties of the test opbject 
            TestRooms.Active = true;
            TestRooms.RoomtypeID = 81;
            TestRooms.RoomFloorNo = 1;
            TestRooms.RoomtypeSize = "4 Guests";
            TestRooms.Roomtype = "Standard";
            TestRooms.DateTime = DateTime.Now.Date;
            //assign the data to the property 
            AllRooms.ThisRoomtype = TestRooms;
            //test to see if the two values are the same 
            Assert.AreEqual(AllRooms.ThisRoomtype, TestRooms);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create 
        //    clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
        //    //vreate some test dat to assign to the property 
        //    Int32 TestData = 1;
        //    //set the count
        //    AllRooms.Count = TestData;
        //    //test to see if the two values are the same 
        //    Assert.AreEqual(AllRooms.Count, TestData);
        //}


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsRoomType> TestList = new List<clsRoomType>();
            //add an item to tge list 
            //create the item of test data 
            clsRoomType TestItem = new clsRoomType();
            //set its properties 
            TestItem.Active = true;
            TestItem.RoomtypeID = 81;
            TestItem.RoomFloorNo = 1;
            TestItem.RoomtypeSize = "4 Guests";
            TestItem.Roomtype = "Standard";
            TestItem.DateTime = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllRooms.RoomtypeList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllRooms.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //createthe item of the test data 
            clsRoomType TestItem = new clsRoomType();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.RoomFloorNo = 1;
            TestItem.RoomtypeSize = "4 guests";
            TestItem.Roomtype = "Standard";
            TestItem.DateTime = DateTime.Now.Date;
            //Set ThisRoom to test the data
            AllRooms.ThisRoomtype = TestItem;
            //add the record 
            PrimaryKey = AllRooms.Add();
            //set the primary key of the test data 
            TestItem.RoomtypeID = PrimaryKey;//find the record 
            //find the record 
            AllRooms.ThisRoomtype.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllRooms.ThisRoomtype, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an isntance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //create the item of test data 
            clsRoomType TestItem = new clsRoomType();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its proeprties
            TestItem.Active = false;
            TestItem.RoomtypeID = 81;
            TestItem.RoomFloorNo = 1;
            TestItem.RoomtypeSize = "4 guests";
            TestItem.Roomtype = "Standard";
            TestItem.DateTime = DateTime.Now.Date;
            //set ThisRoomtype to the test dat 
            AllRooms.ThisRoomtype = TestItem;
            //add the record
            PrimaryKey = AllRooms.Add();
            //set the primary key of the tst data
            TestItem.RoomtypeID = PrimaryKey;
            //find the record 
            AllRooms.ThisRoomtype.Find(PrimaryKey);
            //delete the record 
            AllRooms.Delete();
            //now find the record 
            Boolean Found = AllRooms.ThisRoomtype.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an isntance of the class we want to create 
            clsRoomtypeCollection AllRooms = new clsRoomtypeCollection();
            //create the item of test data 
            clsRoomType TestItem = new clsRoomType();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its proeprties
            TestItem.Active = false;
            TestItem.RoomFloorNo = 1;
            TestItem.RoomtypeSize = "4 guests";
            TestItem.Roomtype = "Standard";
            TestItem.DateTime = DateTime.Now.Date;
            //set ThisRoomtype to the test dat 
            AllRooms.ThisRoomtype = TestItem;
            //add the record
            PrimaryKey = AllRooms.Add();
            //set the primary key of the tst data
            TestItem.RoomtypeID = PrimaryKey;
            //modify the test data 
            TestItem.Active = false;
            TestItem.RoomFloorNo = 1;
            TestItem.RoomtypeSize = "4 guests";
            TestItem.Roomtype = "Standard";
            TestItem.DateTime = DateTime.Now.Date;
            //set the record based on the new test data 
            AllRooms.ThisRoomtype = TestItem;
            //update the record 
            AllRooms.Update();
            //find the record 
            AllRooms.ThisRoomtype.Find(PrimaryKey);
            //test to see Thisroomtype matches the test data 
            Assert.AreEqual(AllRooms.ThisRoomtype, TestItem);
        }
        [TestMethod]
        public void ReportByRoomtypeMethodOK()
        {
            //Create instance of the class we want to create 
            clsRoomtypeCollection Allrooms = new clsRoomtypeCollection();
            //create an instance of te filtred data 
            clsRoomtypeCollection FilteredRooms = new clsRoomtypeCollection();
            //apply a blank string (should return all records)
            FilteredRooms.ReportByRoomtype("");
            //test to see that the two value are the same 
            Assert.AreNotEqual(Allrooms.Count, FilteredRooms.Count);
        }
        [TestMethod]
        public void ReportByRoomTypeTestDataFound()
        {
            //create an instance of the filtered data 
            clsRoomtypeCollection FilteredRoomtype = new clsRoomtypeCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a roomtype that doesnt exist 
            FilteredRoomtype.ReportByRoomtype("Standard");
            //check that the correct nuber of recrods are found
            if (FilteredRoomtype.Count == 2)
            {
                //checl that the first recrod is ID 1
                if (FilteredRoomtype.RoomtypeList[0].RoomtypeID != 81)
                {
                    OK = false;
                }
                //check that the first ID  is 2 
                if (FilteredRoomtype.RoomtypeList[1].RoomtypeID != 82)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                // test to see that there are no recrods 

            }
            Assert.IsTrue(OK);
        }
        // [TestMethod]
        // public void FindMethodOK()
        //{
        //create an instance of the class we want to create 
        //   clsRoomType ARoomtype = new clsRoomType();
        //boolean variable to store the result of the validation 
        //   Boolean Found = false;
        //create some test data to use with the method 
        //   Int32 RoomtypeID = 21;
        //invoke method 
        //  Found = ARoomtype.Find(RoomtypeID);
        //test to see that the result is correct 
        //  Assert.IsTrue(Found);
        //}
        // [TestMethod]
        // public void TestRoomtypeIDFound()
        // {
        //create an instance of the class we want to create 
        //    clsRoomType ARoomtype = new clsRoomType();
        //   //boolean variable to store the result of the validation 
        //   Boolean Found = false;
        //boolean variable to record if data is OK (assume it is)
        //   Boolean OK = true;
        //create some test data to use with the method 
        //Int32 RoomtypeID = 21;
        //invoke method 
        //   Found = ARoomtype.Find(RoomtypeID);
        //check the RoomypeID
        //  if (ARoomtype.RoomtypeID != 21)
        //  {
        //      OK = false;
        //  }
        //test to see that the result is correct 
        //  Assert.IsTrue(OK);

        // }

    }

}

