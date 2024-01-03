using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._8Kyu
{
    public class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            // Your code here
            return array.Length > 0 ?array.Average() : 0;
        }
    }
}
