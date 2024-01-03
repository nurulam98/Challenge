using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class ExpandedForm
    {
        public static string ExpandedForms(long num)
        {
            string numString = num.ToString();
            string blah = "";
            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] != '0')
                {
                    blah += numString[i];
                    blah += new String('0', numString.Length - i - 1);
                    blah += " + ";
                }
            }
            return blah.Substring(0, blah.Length - 3);
        }
    }
}
