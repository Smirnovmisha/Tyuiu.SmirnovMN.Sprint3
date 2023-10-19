using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SmirnovMN.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 0;
            while startValue <= stopValue)
            {
                multSeries = multSeries + Math.Pow((6 / Math.Pow(6, startValue)), 2);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
