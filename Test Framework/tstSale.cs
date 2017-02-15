using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    /// <summary>
    /// Summary description for tstSalePage
    /// </summary>
    [TestClass]
    public class tstSalePage
    {
        public tstSalePage()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InstanceOk()
        {
            clsSalePage NewPage = new clsSalePage();
            Assert.IsNotNull(NewPage);
        }

        [TestMethod]
        public void SaleNo()
        {
            clsSalePage NewPage = new clsSalePage();
            Int32 SomeData;
            SomeData = 1234;
            NewPage.SaleNo = SomeData;
            Assert.AreEqual(SomeData, NewPage.SaleNo);
        }

        [TestMethod]
        public void SaleDate_ExtremeMin()
        {
            clsSalePage NewPage = new clsSalePage();
            string SomeSaleReg;
            string SomeDate;
            Boolean AllOk = false;
            SomeSaleReg = "";
            SomeDate = "1/1/2001";
            AllOk = NewPage.Valid(SomeSaleReg, SomeDate);
            Assert.IsFalse(AllOk);


        }


        [TestMethod]
        public void Validation()
        {
            clsSalePage TestSale = new clsSalePage();
            Boolean OK;
            OK = TestSale.Valid("Mercedes");
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void SaleOK()
        {
            clsSalePage TestSale = new clsSalePage();
            string TestDate = "Mercedes";
            TestSale.Sale = TestDate;
            Assert.AreEqual(TestSale.Sale, TestDate);
            Boolean OK;
            OK = TestSale.Valid("Mercedes");
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void SaleMinLessOne()
        {
            clsSalePage TestSale = new clsSalePage();
            Boolean OK;
            OK = TestSale.Valid("");
            Assert.IsFalse(OK);


        }
    }
}
