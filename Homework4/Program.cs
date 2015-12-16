using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Vasya Victim";
            person.Age = 66;

            Animal animal = new Animal();
            animal.Breed = "Bird";
            animal.Legs = 2;

            ColorPrintClass cp = new ColorPrintClass();
            cp.ColorPrint(person);

            ColorPrintClass ca = new ColorPrintClass();
            ca.ColorPrint(animal);

        }
    }
}
