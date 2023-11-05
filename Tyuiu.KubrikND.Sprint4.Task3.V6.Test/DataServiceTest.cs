using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint4.Task3.V6.Lib;

namespace Tyuiu.KubrikND.Sprint4.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] numsArray = new int[,] { { 8, 8, 3, 4, 5 },
                                            { 8, 6, 6, 4, 6 },
                                            { 3, 6, 5, 3, 4 },
                                            { 5, 6, 3, 7, 5 },
                                            { 7, 8, 5, 6, 6 } };
            int res = dataService.Calculate(numsArray), wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}