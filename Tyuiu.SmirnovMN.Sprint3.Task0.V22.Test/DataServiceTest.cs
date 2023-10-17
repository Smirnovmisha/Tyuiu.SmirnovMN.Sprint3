using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint3.Task0.V22.Lib;

namespace Tyuiu.SmirnovMN.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int starValue = 1;
            int stopValue = 8;

            double res = ds.GetSumSeries(value, starValue, stopValue);

            double wait = 31.328;

            Assert.AreEqual(wait, res);


        }
    }
}
