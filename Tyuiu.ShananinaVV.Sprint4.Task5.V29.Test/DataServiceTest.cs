using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint4.Task5.V29.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] { { -1, 4, 5, 4, 8 },
                                          { 7, 6, -7, 7, 4 },
                                          { 4, 4, 3, -4, 6 },
                                          { 6, 5, -8, 4, 0 },
                                          { -1, 7, -3, 7, 7 } };

            int res = ds.Calculate(mtrx);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
