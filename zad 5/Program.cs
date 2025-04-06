namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ComputerProgram> computerPrograms = ComputerProgramGenerator.GeneratePrograms();
            PrintPrograms(computerPrograms);
            Console.WriteLine();
            (bool result, int virusID, string affectedProgramName) = ContainsDuplicate(computerPrograms);
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"VIRUSES? {result} at ID: {virusID}" +
                    $"\nAffected program: " +
                    $"{affectedProgramName}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Viruses? {result}");
                Console.WriteLine("No viruses here!");
            }
            
            Console.ResetColor();
        }

        public static (bool, int, string) ContainsDuplicate(List<ComputerProgram> programs)
        {
            SortedDictionary<int, ComputerProgram> keyValuePairs = new SortedDictionary<int, ComputerProgram>();
            foreach (var program in programs)
            {
                if (keyValuePairs.ContainsKey(program.ID))
                {
                    return (true, program.ID, keyValuePairs[program.ID].Name);
                }
                keyValuePairs.Add(program.ID, program);
            }
            return (false, default, null);
        }

        public static void PrintPrograms(List<ComputerProgram> programs)
        {
            foreach (var program in programs)
            {
                Console.WriteLine(program);
            }
        }
    }
}
