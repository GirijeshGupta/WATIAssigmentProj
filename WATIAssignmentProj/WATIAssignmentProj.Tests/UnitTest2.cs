using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WATIAssignmentProj.Controllers;
using WATIAssignmentProj.Logics.BLL;

namespace WATIAssignmentProj.Tests
{
    [TestClass]
    public class CalculationTestBed
    {
        [TestMethod]
        public void TestMethod_Add()
        {
            Calculation bm = new Calculation();
            decimal res = bm.Sum(10, 10);
            Assert.AreEqual(res, 20);
        }
    }
}
