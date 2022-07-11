Console.WriteLine("DataStructure Algorithms : \n1.Permutations\n2.Binary Search the word in file\nEnter your option");
int option = Convert.ToInt32(Console.ReadLine());

switch(option)
{
    case 1:

        DS_Algorithms.Permutations permutations = new DS_Algorithms.Permutations();
        Console.WriteLine("Enter the string : ");
        string word = Console.ReadLine();
        int len = word.Length;
        Console.WriteLine("Permutations are : ");
        permutations.permute(word, 0, len - 1);
        break;
        
        case 2:
        DS_Algorithms.BinarySearch_word search = new DS_Algorithms.BinarySearch_word();
        Console.WriteLine("Enter the word to search : ");
        string words = Console.ReadLine();
        search.search(words);
        break;
        default:
        Console.WriteLine("Invalid option");
        break;

}
