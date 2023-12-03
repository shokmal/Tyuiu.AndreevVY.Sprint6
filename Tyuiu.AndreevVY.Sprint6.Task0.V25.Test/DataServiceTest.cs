using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint6.Task0.V25.Lib;

namespace Tyuiu.AndreevVY.Sprint6.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.866;
            Assert.AreEqual(wait, res);
        }
    }
}
