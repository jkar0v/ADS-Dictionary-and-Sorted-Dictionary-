using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class ComputerProgram
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public ComputerProgram(int size, string name, int id)
        {
            Size = size;
            Name = name;
            ID = id;
        }
        public override string ToString()
        {
            return $"{ID}: {Name}, {Size}MB";
        }
    }
}
