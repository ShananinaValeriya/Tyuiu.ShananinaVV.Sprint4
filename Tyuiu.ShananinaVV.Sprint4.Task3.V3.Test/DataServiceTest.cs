using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint4.Task3.V3.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] ar = new int[5, 5] { { 9, 4, 5, 4, 8 },
                                        { 7, 6, 7, 7, 4 },
                                        { 4, 4, 3, 5, 6 },
                                        { 6, 5, 9, 4, 9 },
                                        { 9, 7, 8, 7, 7 } };

            int res = ds.Calculate(ar);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
