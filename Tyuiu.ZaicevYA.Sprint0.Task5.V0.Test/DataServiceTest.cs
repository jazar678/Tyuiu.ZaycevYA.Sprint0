using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaicevYA.Sprint0.Task5.V0.Lib;




namespace Tyuiu.ZaicevYA.Sprint0.Task5.V0.Test
{
    public class DataServiceTest
    {
        public void CheckedAdditioslVailed()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSabtractionVailid()
        {
            Assert.AreEqual(2, DataService.Sabtraction(8, 6));
        }
        public void CheckedMultiplicationVailed()
        {
            Assert.AreEqual(8, DataService.Multiplication(4, 2));
        }        
        public void CheckedDivisionVailed()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
}
