using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    public class GrasshopperSummation
    {
        public static int summation(int num)
        {
            int result = 0;
            for(int i = 1; i <= num;i++)
            {
                result += i;
            }
            return result;
        }

        //Refactor
        //public static int summation(int num)
        //{
        //    return num * (num + 1) / 2;
        //}
    }
}
