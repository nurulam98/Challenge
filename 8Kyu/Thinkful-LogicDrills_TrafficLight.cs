using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    /*
     * You're writing code to control your town's traffic lights. You need a function to handle each change from green, to yellow, to red, and then to green again.
     * Complete the function that takes a string as an argument representing the current state of the light and returns a string representing the state the light should change to.
     * For example, when the input is green, output should be yellow.
     */
    public class Thinkful_LogicDrills_TrafficLight
    {
        public static string UpdateLight(string current)
        {
            //Do Some Magic
            string result = string.Empty;
            if (current == "green")
            {
                result = "yellow";
            }
            else if (current == "yellow")
            {
                result = "red";
            }
            else
            {
                result = "green";
            }

            return result;
        }
    }
}
