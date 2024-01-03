using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class TheSupermarketQueue
    {
        public static long QueueTime(int[] customers, int n)
        {
            var registers = new List<int>(Enumerable.Repeat(0, n));

            foreach (int cust in customers)
            {
                int minArray = registers.Min();
                int index = registers.IndexOf(minArray);
                registers[registers.IndexOf(registers.Min())] += cust;
            }
            return registers.Max();
        }
    }
}
