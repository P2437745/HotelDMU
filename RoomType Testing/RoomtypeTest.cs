using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomType_Testing
{
    [TestClass]
    public class RoomtypeTest
    {
        [TestMethod]
        public void TInstanceOk()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomType = new clsRoomType();
            //test to see that it exists
            Assert.IsNotNull(ARoomType);
        }
        
    }
}
