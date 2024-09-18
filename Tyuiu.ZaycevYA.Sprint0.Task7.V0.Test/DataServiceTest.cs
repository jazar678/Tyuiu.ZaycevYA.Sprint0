using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaycevYA.Sprint0.Task7.V0.Lib;


namespace Tyuiu.ZaycevYA.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void T1()
        {
            int[] nubs1 = new int[] { 1, 1, 1, 1, 1, };
            int[] nubs2 = new int[] { 1, 1, 1, 1, 1, };
            int[] nubs3 = new int[] { 2, 2, 2, 2, 2, };

            int[] res = DataService.Add(nubs1, nubs2);
            CollectionAssert.AreEqual(nubs3, res);

        }
    }
}