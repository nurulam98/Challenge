using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class TwoSums
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Length -1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                        break;
                    }
                }

                if (result.Count == 2)
                {
                    break;
                }
            }
            return result.OrderBy(a => a).ToArray();
        }
    }
}
