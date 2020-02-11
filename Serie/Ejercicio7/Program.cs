/*
Creancion suma de dos numeros complejos mediante el uso de una clase de numero complejo.
*/

using System;

namespace Ejercicio7
{
    class Program
    {
        //Esta funcion realiza la operacion de la suma de numeros complejos mediante sus atributos.
        static NumeroComplejo Sumar(NumeroComplejo nc1, NumeroComplejo nc2) 
        {
            NumeroComplejo resultado = new NumeroComplejo(nc1.pr+nc2.pr, nc1.pi + nc2.pi);
            return resultado;
        }
        static void Main(string[] args)
        {
            //Creaciom de lo numeros complejos
            NumeroComplejo NC1 = new NumeroComplejo(1,-3);
            NumeroComplejo NC2 = new NumeroComplejo(0, 2);
            //Mostrando los numeros complejos
            Console.WriteLine("Primer numero complejo");
            Console.WriteLine(NC1.Imprimir()+"\n");
            Console.WriteLine("Segundo numero complejo");
            Console.WriteLine(NC2.Imprimir() + "\n");
            //Realizacion de la suma de numeros complejos.
            var res = Sumar(NC1, NC2);
            Console.WriteLine("\nEl resultado de la suma de {0} con {1} es: {2}\n", NC1.Imprimir(), NC2.Imprimir(), res.Imprimir());
            Console.WriteLine("\nPresiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
