using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining
{
    public class FindTheSmallestIntegerInTheArray
    {
        public static int FindSmallestInt(int[] args)
        {
            return args.Min(x => x);
        }
    }
}
