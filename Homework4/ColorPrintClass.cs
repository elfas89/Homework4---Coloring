using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework4
{
    class ColorPrintClass
    {
        public void ColorPrint(object obj)
        {
            Type type = obj.GetType();

            ConsoleColor color;

            foreach (PropertyInfo prop in type.GetProperties())
            {
                //Console.WriteLine(prop.Name);

                try
                {
                    //записываем в переменную значение атрибута, примененного к свойству
                    color = ((ColorAttribute)prop.GetCustomAttribute(typeof(ColorAttribute))).ColorName;

                }
                catch (Exception)
                {
                    //"стандартное" значение
                    color = ConsoleColor.White;
                }
                Console.ForegroundColor = color;
                Console.WriteLine(prop.Name + ": " + prop.GetValue(obj));
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }
}
