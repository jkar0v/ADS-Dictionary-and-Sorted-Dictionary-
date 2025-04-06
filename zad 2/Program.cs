namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a string: ");
            string input = Console.ReadLine();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach(var word in input.Split(' '))
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }
            Console.WriteLine("Word count:");
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
