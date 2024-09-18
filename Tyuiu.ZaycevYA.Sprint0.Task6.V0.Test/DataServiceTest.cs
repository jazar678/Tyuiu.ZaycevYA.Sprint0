using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaycevYA.Sprint0.Task6.V0.Lib;


namespace Tyuiu.ZaycevYA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheakA()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.Cheak(numbers);
            Assert.AreEqual(15, (res));
        }
        public void CheakB()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.CheakSabst(numbers);
            Assert.AreEqual(-15, (res));
        }
        public void CheakC()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.CheakMult(numbers);
            Assert.AreEqual(120, (res));
        }


    }

}