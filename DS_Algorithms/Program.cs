Console.WriteLine("DataStructure Algorithms : \n1.Permutations\n2.Binary Search the word in file\n3.Insertion Sort\nEnter your option");
int option = Convert.ToInt32(Console.ReadLine());

DS_Algorithms.Logical_Programs program = new DS_Algorithms.Logical_Programs();

switch (option)
{
    case 1:
        Console.WriteLine("Enter the string : ");
        string word = Console.ReadLine();
        int len = word.Length;
        Console.WriteLine("Permutations are : ");
        program.permute(word, 0, len - 1);
        break;
        
        case 2:
        Console.WriteLine("Enter the word to search : ");
        string words = Console.ReadLine();
        program.search(words);
        break;
    case 3:
        Console.WriteLine("Enter number of words to insert : ");
        int count = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[count];
        for (int i =0; i < count; i++)
        {
            Console.WriteLine("Enter the string to add : ");
            string s = Console.ReadLine();
            array[i] = s;
        }
        program.InsertionSort(array);
        break;

        default:
        Console.WriteLine("Invalid option");
        break;

}
