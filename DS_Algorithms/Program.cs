DS_Algorithms.Permutations permutations = new DS_Algorithms.Permutations();

Console.WriteLine("Enter the string : ");
string word = Console.ReadLine();
int len = word.Length;
Console.WriteLine("Permutations are : ");
permutations.permute(word, 0, len - 1);
