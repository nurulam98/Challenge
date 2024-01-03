using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class MexicanWave
    {
        public List<string> wave(string str)
        {
            if (str.Length == 0)
            {
                return new List<string> { };
            }
            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    char cToUpper = char.ToUpper(str[i]);
                    char[] strToChar = str.ToCharArray();
                    strToChar[i] = cToUpper;
                    list.Add(string.Join("", strToChar));
                }
            }
            return list;
        }
    }
}
