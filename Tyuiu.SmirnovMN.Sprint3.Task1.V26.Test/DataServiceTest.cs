using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint3.Task1.V26.Lib;


namespace Tyuiu.SmirnovMN.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 8;

            double res = ds.GetMultiplySeries(value , startValue, stopValue);

            double wait = 1.44;

            Assert.AreEqual(res, wait);

        }
    }
}
