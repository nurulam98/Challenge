using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining._7Kyu
{
    public class DnaStrand
    {
        public string MakeComplement(string dna)
        {
            //Your code
            char[] strToChar = dna.ToCharArray();
            for (int i = 0; i < strToChar.Length; i++)
            {
                if (strToChar[i] == 'A')
                {
                    strToChar[i] = 'T';
                }
                else if (strToChar[i] == 'T') {
                    strToChar[i] = 'A';
                }
                else if (strToChar[i] == 'C')
                {
                    strToChar[i] = 'G';
                }
                else if (strToChar[i] == 'G')
                {
                    strToChar[i] = 'C';
                }
            }
            return string.Join("", strToChar);
        }
    }
}
