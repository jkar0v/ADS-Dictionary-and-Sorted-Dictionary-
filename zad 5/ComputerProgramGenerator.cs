using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class ComputerProgramGenerator
    {
        private static Random _random = new Random();

        public static List<ComputerProgram> GeneratePrograms()
        {
            HashSet<int> usedIds = new HashSet<int>();
            List<ComputerProgram> programs = new List<ComputerProgram>();

            for (int i = 0; i < 98; i++)
            {
                int id;
                do
                {
                    id = _random.Next(1000, 9999);
                } while (usedIds.Contains(id));

                usedIds.Add(id);
                programs.Add(new ComputerProgram(_random.Next(10, 500), $"Program{i + 1}", id));
            }

            // Select a random existing ID to duplicate for the Virus program
            // Randomly decide whether to add a virus
            if (_random.Next(2) == 0) // 50% chance
            {
                int duplicateId = programs[_random.Next(programs.Count)].ID;
                programs.Add(new ComputerProgram(_random.Next(10, 500), "MightyVirus", duplicateId));
            }

            return programs;
        }
    }
}
