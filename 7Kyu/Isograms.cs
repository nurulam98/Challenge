using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._7Kyu
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
        {
            // Code on you crazy diamond!
            char[] temp = new char[str.Length];
            int count = 0;
            foreach(char c in str.ToCharArray())
            {
                char lowerChar = char.ToLower(c);
                if (temp.Where(x => x == lowerChar).FirstOrDefault() != 0)
                {
                    return false;
                }
                else
                {
                    temp[count] = lowerChar;
                    count++;
                }
            }
            return true;
        }
    }
}
