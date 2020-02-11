/*
Este progrma escribe f antes de cuaquier vocal.
*/

using System;

namespace Ejercicio3
{
    class Program
    {
        //Esta funcion coloca la F antes de una vocal
        static void AgregarF(string cad) 
        {
            string cadlow = cad.ToLower();
            for (int i = 0; i < cad.Length; i++)
            {
                //En esta seccion es donde se realiza la comparacion para colocar la f
                if (cadlow[i] == 'a' || cadlow[i] == 'e' || cadlow[i] == 'i' || cadlow[i] == 'o' || cadlow[i] == 'u')
                    Console.Write("f{0}",cad[i]);
                else
                    Console.Write("{0}", cad[i]);
            }
        }
        static void Main(string[] args)
        {
            //Se pide la cadean.
            Console.WriteLine("Ingrese una cadena: ");
            string cadena = Console.ReadLine();
            AgregarF(cadena);
            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
