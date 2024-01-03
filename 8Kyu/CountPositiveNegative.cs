using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._8Kyu
{
    public class CountPositiveNegative
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null) {
                return new int[] { };
            }
            int[] result = new int[2];
            foreach (int i in input)
            {
                if (i < 0)
                {
                    result[1] += i;
                }
                else if(i > 0)
                {
                    result[0] += 1;
                }
            }
            return input.Length == 0 ? new int[] { } : result; //return an array with count of positives and sum of negatives
        }
    }
}
