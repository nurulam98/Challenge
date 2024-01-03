﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    /*
     * You ask a small girl,"How old are you?" She always says, "x years old", where x is a random number between 0 and 9.
     * Write a program that returns the girl's age (0-9) as an integer.
     * Assume the test input string is always a valid string. For example, the test input may be "1 year old" or "5 years old". The first character in the string is always a number.
     */
    public class ParseIntFromChar
    {
        public static int GetAge(string inputString)
        {
            // return correct age (int). Happy coding :)
            return Convert.ToInt32(inputString.Substring(0, 1));
        }
    }
}
