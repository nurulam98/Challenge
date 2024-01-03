using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    public class InvertValues
    {
        public static int[] InvertValuesFunc(int[] input)
        {
            int[] result = new int[input.Length];
            int count = 0;
            foreach (int i in input)
            {
                result[count] = -i;
                count++;
            }
            return result;
            //Code it!
        }

        //Refactor
        //public static int[] InvertValuesFunc(int[] input)
        //{
        //    return input.Select(n => -n).ToArray();
        //}
    }
}
