using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public class AreTheySame
    {
        public bool comp(int[] a, int[] b)
        {
            if(a.Length != b.Length) return false;

            foreach (int i in a)
            {
                var x = b.Contains(i * i);
                if (!x)
                {
                    return false;
                }
                else
                {
                    b[Array.IndexOf(b, i * i)] = 0;
                }
            }
            // your code
            return true;
        }
    }
}
