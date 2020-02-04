using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomType_Testing
{
    [TestClass]
    public class tstReservation
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsReservation AnReservation = new clsReservation();
            //test to see that it exists
            Assert.IsNotNull(AnReservation);
        }
    }
}
