using FlashMarketClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlashMarketTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we are making
            clsCustomer AStaff = new clsCustomer();
            // test to see it actually exists
            Assert.IsNotNull(AStaff);
        }
    }
}
