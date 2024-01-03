using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class CountCharString
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char,int> result = new Dictionary<char,int>();
            foreach (char c in str.ToCharArray())
            {
                if (result.ContainsKey(c))
                {
                    int value = result[c];
                    value += 1;
                    result[c] = value;
                }
                else
                {
                    result[c] = 1;
                }
            }
            return result;
        }
    }
}
