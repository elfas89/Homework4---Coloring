using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColorAttribute : System.Attribute
    {
        public ConsoleColor ColorName { get; set; }

        public ColorAttribute(ConsoleColor color)
        {
            ColorName = color;
        }
       
    }
}
