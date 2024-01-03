using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class TribonacciSequence
    {
        public double[] Tribonnaci(double[] signature, int n)
        {
            // hackonacci me
            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (i < 3)
                {
                    result[i] = signature[i];
                }
                else
                {
                    result[i] = result[i - 1] + result[i - 2] + result[i - 3];
                }

            }

            return result;
        }
    }
}
