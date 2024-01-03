using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class SplitStrings
    {
        public string[] Solution(string str)
        {
            List<string> list = new List<string>();
            string tempValue = "";
            for(int i = 0; i < str.Length; i++) {
                if (tempValue.Length < 2)
                {
                    tempValue += str[i];
                }
                if (tempValue.Length == 1 && i == str.Length - 1)
                {
                    tempValue += "_";
                }
                if (tempValue.Length == 2)
                {
                    list.Add(tempValue);
                    tempValue = "";
                }
            }
            return list.ToArray();
        }
    }
}
