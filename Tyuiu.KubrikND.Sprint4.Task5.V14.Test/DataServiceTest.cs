using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint4.Task5.V14.Lib;

namespace Tyuiu.KubrikND.Sprint4.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { -5, 4, 2, -3, 1 },
                             { -3, -5, -5, 4, 1 },
                             { -2, 2, -3, -1, 6 },
                             { 7, 7, -4, 5, 3 },
                             { 7, 4, -5, -1, -3 } };
            int wait = 13;
            var res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
