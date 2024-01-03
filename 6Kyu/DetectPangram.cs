using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class DetectPangram
    {
        public static bool IsPangram(string str)
        {
            
            Dictionary<char,int> charMap = new Dictionary<char, int>();
            foreach (char c in str.ToLower().Replace(" ",string.Empty))
            {
                if(char.IsLetter(c))
                {
                    if (charMap.ContainsKey(c))
                    {
                        int value = charMap[c];
                        charMap[c] = value + 1;
                    }
                    else
                    { charMap[c] = 1;
                    }
                }
            }
            return charMap.Count < 26 ? false : true;
            //Refactor
            //return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }
    }
}
