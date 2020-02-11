using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        private static readonly string[] colors = { "Magenta", "Rojo", "Blanco", "Azul", "Verde" };
        private static readonly string[] removecolors = { "Rojo", "Blanco", "Azul" };
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            foreach (var color in colors)
            {
                list.Add(color);
            }

            List<string> removelist = new List<string>(removecolors);

            Mostrarlista(list);

            Console.ReadKey();
        }
        private static void Mostrarlista(List<string> list) 
        {
            foreach (var elemento in list) 
            {
                Console.Write("{0} ",elemento);
            }
        }
    }
}
