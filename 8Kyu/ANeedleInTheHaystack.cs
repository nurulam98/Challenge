using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._8Kyu
{
    public class ANeedleInTheHaystack
    {
        public static string FindNeedle(object[] haystack)
        {
            //Code goes here!
            return $"found the needle at position {haystack.ToList().IndexOf("needle")}";
        }
    }
}
