using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._7Kyu
{
    public class SumOfOddNumbersTree
    {
        public static long RowSumOddNumbers(long n)
        {
            long result = 0;
            long lastNumber = 1;
            for (int i = 1; i <=n; i++)
            {
                long[] temp = new long[i];
                int count = 0;
                while(lastNumber < long.MaxValue)
                {
                    if (lastNumber % 2 != 0)
                    {
                        temp[count] = lastNumber;
                        if (temp[i-1] != 0)
                        {
                            lastNumber++;
                            break;
                        }
                        count++;
                    }
                    lastNumber++;
                }
                if (i == n)
                {
                    result = temp.Sum();
                }
            }
            return result;
        }
        /*
If you look down the middle of the triangle, you will see square numbers (you don't see them on even rows) like
1, 4, 9, 16, 25, 36...
  
             1                 <-- middle number is 1
          3     5              <-- middle number is 4
       7     9    11           <-- middle number is 9
   13    15     17    19       <-- middle number is 16
21    23    25     27    29    <-- middle number is 25

The middle number is also the average of the row numbers
 * The average of the second row is 4: (3+5)/2
 * The average of the third  row is 9: (7+9+11)/3

To work out the sum of a sequence we can multiply the average by the number of terms in the sequence

Notice that the second row has 2 terms, the third row has 3 terms, the Nth row has N terms
 
So to find a sum of a row we can multiply the average (the square of the row number) by the number of terms 
(also the row number)

This means that the answer is actually simply the cube (power 3) of the row number
  
  */

        //public static long RowSumOddNumbers(long n) => n * n * n;
    }
}
