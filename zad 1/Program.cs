namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Alex");
            dictionary.Add(2, "Boris");
            dictionary.Add(3, "Sofia");
            dictionary.Add(8, "Jivko");

            Console.Write("Let's check for a student, using the ID number!" +
                "\nWrite an ID number: ");
            int id = int.Parse(Console.ReadLine());
            if (dictionary.ContainsKey(id))
            {
                Console.WriteLine($"The student with ID number {id} is {dictionary[id]}.");
            }
            else
            {
                Console.WriteLine($"There is no student with ID number {id} :(");
            }
        }
    }
}
