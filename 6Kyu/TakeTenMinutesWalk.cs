using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class TakeTenMinutesWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length < 10 || walk == null || walk.Length > 10)
            {
                return false;
            }
            int x = 0;
            int y = 0;
            //insert brilliant code here
            foreach (string str in walk)
            {
                if (str.ToLower() == "n")
                {
                    y++;
                }
                if (str.ToLower() == "s")
                {
                    y--;
                }
                if (str.ToLower() == "w")
                {
                    x--;
                }
                if (str.ToLower() == "e")
                {
                    x++;
                }
            }
            if (x == 0 && y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
