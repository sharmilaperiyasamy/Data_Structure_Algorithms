using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithms
{
    internal class Permutations
    {
        public void permute(String str,int p, int q)
        {
            if (p == q)
                Console.WriteLine(str);
            else
            {
                for (int i = p; i <= q; i++)
                {
                    str = swap(str, p, i);
                    permute(str, p + 1, q);
                    str = swap(str, p, i);
                }
            }
        }
        public String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
