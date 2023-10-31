using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint4.Task0.V4.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetMultEvenArrEl(array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
