using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    public class StringEndWith
    {
        public static bool Solution(string str, string ending)
        {
            bool result = false;
            int lengthString = str.Length;
            int indexEnding = str.LastIndexOf(ending);
            if((indexEnding + ending.Length == lengthString && indexEnding >= 0) || ending.Length == 0)
            {
                result = true;
            }
            return result;
        }

        //Refactor Solution
        //public static bool Solution(string str, string ending)
        //{
        //    return str.EndsWith(ending);
        //}

    }
}
