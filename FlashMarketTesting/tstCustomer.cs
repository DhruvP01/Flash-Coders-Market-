using FlashMarketClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlashMarketTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we are making
            clsCustomer ACustomer = new clsCustomer();
            // test to see it actually exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
