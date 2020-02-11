/*
Programa que solo hace una prueba de las clases CarroBMW y CarroVW con herencia de la clase Carro.
*/
using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroBMW cBMW = new CarroBMW(100000,1.6);
            CarroVW cVW = new CarroVW(180000,1.9);
            Console.WriteLine("Probando BMW");
            cBMW.encender();
            cBMW.estado();
            cBMW.apagar();
            cBMW.estado();
            Console.WriteLine(cBMW.ToString());

            Console.WriteLine("\nProbando VW");
            cVW.encender();
            cVW.estado();
            cVW.apagar();
            cVW.estado();
            Console.WriteLine(cVW.ToString());
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
