using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework4
{
    public class Person
    {   [Color(ConsoleColor.Red)]
        public string Name { get; set; }
        [Color(ConsoleColor.Blue)]
        public int Age { get; set; }
    }
}
