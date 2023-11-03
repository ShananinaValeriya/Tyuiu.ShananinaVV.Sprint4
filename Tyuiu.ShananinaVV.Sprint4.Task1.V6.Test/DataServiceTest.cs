﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint4.Task1.V6.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };

            int res = ds.Calculate(numsArray);
            int wait = 1024;

            Assert.AreEqual(wait, res);
        }
    }
}
