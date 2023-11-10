using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint4.Task6.V20.Lib;

namespace Tyuiu.ShananinaVV.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var sb = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература"};
            string[] res = ds.Calculate(sb);
            string[] wait = { "Физика", "Химия", "Биология", "География", "История" };
            CollectionAssert.AreEqual(wait, res); 
        }
    }
}
