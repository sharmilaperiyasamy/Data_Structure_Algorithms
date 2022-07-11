using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithms
{
    internal class BinarySearch_word
    {
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
    }
}
