using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            StandardDeviation();
        }
        static void StandardDeviation()
        {
            double[] dataPoints = { 2, 3, 7, 5, 5, 1, 8, 5, 3, 4, 4, 6 };

            //find the total
            double total = 0;
            for (int i = 0; i < dataPoints.Length; i++)
            {
                total += dataPoints[i];
            }
            double average= total/dataPoints.Length;
            double variance = 0;
            for (int x = 0; x < dataPoints.Length; x++)
            {
                variance +=Math.Pow((dataPoints[x] - average), 2);
            }

            var standardDev= Math.Sqrt(variance/dataPoints.Length);
            Console.WriteLine($"the standard deviation is {standardDev}");
            Console.ReadLine();
        }
    }
}
