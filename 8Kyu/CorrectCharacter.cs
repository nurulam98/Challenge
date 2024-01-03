using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    public class CorrectCharacter
    {
        public static string Correct(string text)
        {
            return text.Replace("5","S").Replace("0","O").Replace("1","I");
        }
    }
}
