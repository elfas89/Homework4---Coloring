using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework4
{
    class Animal
    {   [Color(ConsoleColor.Green)]
        public string Breed { get; set; }
        [Color(ConsoleColor.Yellow)]
        public int Legs { get; set; }
    }
}
