using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._7Kyu
{
    public class MinMax
    {
        public int[] minMax(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
            // your code
        }
        public BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] result = new BigInteger[n + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (BigInteger)Math.Pow(2, i);
            }

            return result;
        }
    }
}
