using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {




        [TestMethod]
        public void InstanceOK()
        {
            clsAddress NewPage = new clsAddress();
            Assert.IsNotNull(NewPage);
        }
    }
}
