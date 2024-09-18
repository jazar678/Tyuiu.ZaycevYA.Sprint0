using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaycevYA.Sprint0.Task4.V0.Lib;


namespace Tyuiu.ZaycevYA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditioslVailed()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }



        [TestMethod]
        public void CheckedSabtractionVailid()
        {
            Assert.AreEqual(2, DataService.Sabtraction(8, 6));
        }
        [TestMethod]
        public void CheckedMultiplicationVailed()
        {
            Assert.AreEqual(8, DataService.Multiplication(4, 2));


        }



        [TestMethod]

        public void CheckedDivisionVailed()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
