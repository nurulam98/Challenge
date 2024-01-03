using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._8Kyu
{
    public class SumWithoutMaxAndMin
    {
        public static int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Length == 0 ? 0:  numbers.Sum() - numbers.Max() - numbers.Min();
        }
    }
}
