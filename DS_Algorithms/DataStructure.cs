using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithms
{
    internal class DataStructure
    {
        Node head;

        //uc8 unordered list
        public void UnOrdered(string str)
        {
            string text = File.ReadAllText(@"C:\Users\Lenovo\source\repos\Bridgelabz\Data_Structure_Algorithms\Binary.txt");
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Node node = new Node(words[i]);
                if (this.head == null)
                    this.head = node;
                else
                {
                    node.next = this.head;
                    this.head = node;
                }
            }
            Node temp = this.head;
            Node prev = null;
            int flag = 0;
            while (temp != null)
            {
                if (temp.data.Equals(str))
                {
                    prev.next = temp.next;
                    flag = 1;
                }
                prev = temp;
                temp = temp.next;
            }
            if (flag == 0)
            {
                Node node = new Node(str);
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("List After searching word:");
            Node node1 = this.head;
            string[] array = new string[100];
            int j = 0;
            while (node1 != null)
            {
                array[j] = node1.data + " ";
                node1 = node1.next;
                j++;
            }
            string concat = string.Concat(array);
            Console.WriteLine(concat);
            File.WriteAllText(@"C:\Users\Lenovo\source\repos\Bridgelabz\Data_Structure_Algorithms\Binary.txt", concat);
        }
        //uc9 ordered list
        public void Ordered(string str)
        {
            string text = File.ReadAllText(@"C:\Users\Lenovo\source\repos\Bridgelabz\Data_Structure_Algorithms\Binary.txt");
            string[] words = text.Split(' ');
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Node node = new Node(words[i]);
                if (this.head == null)
                    this.head = node;
                else
                {
                    node.next = this.head;
                    this.head = node;
                }
            }
            Node temp = this.head;
            Node prev = null;
            int flag = 0;
            while (temp != null)
            {
                if (temp.data.Equals(str))
                {
                    prev.next = temp.next;
                    flag = 1;
                }
                prev = temp;
                temp = temp.next;
            }
            if (flag == 0)
            {
                Node node = new Node(str);
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("List After searching word:");
            Node node1 = this.head;
            string[] array = new string[100];
            int j = 0;
            while (node1 != null)
            {
                array[j] = node1.data + " ";
                node1 = node1.next;
                j++;
            }
            string concat = string.Concat(array);
            Console.WriteLine(concat);
            File.WriteAllText(@"C:\Users\Lenovo\source\repos\Bridgelabz\Data_Structure_Algorithms\Binary.txt", concat);
        }
    }
}
