using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._6Kyu
{
    public static class FindTheOddInt
    {
        //public static int find_it(int[] seq)
        //{
        //    Dictionary<int,int> map = new Dictionary<int,int>();
        //    foreach (int i in seq) {
        //        if(map.ContainsKey(i))
        //        {
        //            int value = map[i];
        //            value += 1;
        //            map[i] = value;
        //        }
        //        else
        //        {
        //            map[i] = 1;
        //        }
        //    }
        //    var sortedMap = map.Where(x=> x.Value %  2 == 1).Select(x=> x.Key).FirstOrDefault();
        //    return sortedMap;
        //}
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }
}
