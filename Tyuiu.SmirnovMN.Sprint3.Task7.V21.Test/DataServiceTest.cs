using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint3.Task7.V21.Lib;


namespace Tyuiu.SmirnovMN.Sprint3.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] valueWaitArray = new double[len];
           
            valueWaitArray[0] = 22.57;
            valueWaitArray[1] = 16.70;
            valueWaitArray[2] = 12.03;
            valueWaitArray[3] = 9.17;
            valueWaitArray[4] = 7.09;
            valueWaitArray[5] = 4;
            valueWaitArray[6] = -0.92;
            valueWaitArray[7] = -6.84;
            valueWaitArray[8] = -11.98;
            valueWaitArray[9] = -15.31;
            valueWaitArray[10] = -17.44;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }   
    }
}
