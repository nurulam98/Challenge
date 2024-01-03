using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._7Kyu
{
    public class OnesAndZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            //Code here
            int powNum = BinaryArray.Length-1;
            int result = 0;
            for(int i = 0; i < BinaryArray.Length; i++)
            {
                result += BinaryArray[i] * ((int)Math.Pow(2, powNum));
                powNum--;
            }
            return result;
        }
    }
}
