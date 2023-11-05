using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KubrikND.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KubrikND.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 7, 4, 6, 3, 8, 2, 3, 5, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}
