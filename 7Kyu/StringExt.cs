using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._7Kyu
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            string[] initialString = s.Split(' ');
            string[] resultString = new string[initialString.Length];
            int countResult = 0;
            foreach (string str in initialString)
            {
                char[] chars = str.ToCharArray();
                char[] charResult = new char[chars.Length];
                int count = 0;
                foreach (char c in chars)
                {
                    char tempChar = c;
                    if (char.IsUpper(c))
                    {
                        tempChar = char.ToLower(c);
                    }
                    else if(char.IsLower(c))
                    {
                        tempChar = char.ToUpper(c);
                    }
                    charResult[count] = tempChar;
                    count++;
                }
                resultString[countResult] = string.Join("", charResult).ToString();
                countResult++;
            }
            return string.Join(" ",resultString);
        }
    }
}
