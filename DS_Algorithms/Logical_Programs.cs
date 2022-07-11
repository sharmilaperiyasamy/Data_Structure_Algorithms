using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithms
{
    internal class Logical_Programs
    {
        // uc1 Permutations
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
//uc2 Binary search tree
        public void search(string str)
        {
            string text = File.ReadAllText(@"C:\Users\Lenovo\source\repos\Bridgelabz\Data_Structure_Algorithms\Binary.txt");
            string[] words = text.Split(' ');
            Array.Sort(words);
            int flag = 0;
            int i = 0, len = words.Length;
            while (i < len - 1)
            {

                int cen = (i + len) / 2;
                if (words[cen].Equals(str) || words[cen + 1].Equals(str) || words[cen - 1].Equals(str))
                {
                    Console.WriteLine("Expected Word is found in the file.");
                    return;
                }
                else if (words[cen].CompareTo(str) > 0)
                    len = cen - 1;
                else if (words[cen].CompareTo(str) < 0)
                    i = cen + 1;
            }
            if (flag == 0)
            {
                Console.WriteLine("Expected word not found in file.");
            }
        }
//uc3 insertion sort
        public void InsertionSort(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
