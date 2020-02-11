/*
Programam que muestra numeros naturales hasta el numero ingresado por el usuario.
En este programa se considera al dero como numero natural
*/

using System;

namespace Eje1
{
    class Program
    {
        //Funcion que reliza el conteo de numeros naturales. 
        static void NaturalCount(uint limit)
        {
            Console.WriteLine("Los numeros del 0 al {0} son: ", limit);
            for (int i = 0; i <= limit; i++) 
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el numero natural hasta cual se va a mostrar:");
                uint limite = Convert.ToUInt32(Console.ReadLine());
                NaturalCount(limite);
            }
            //Se revisa que el usuario no ingrese letra y numero negativos
            catch (FormatException)
            {
                Console.WriteLine("\nERROR: El numero ingresado debe de ser un entero positivo");
            }
            catch (OverflowException ov)
            {
                Console.WriteLine("\nERROR: El numero ingresado debe de ser un entero positivo");
            }
            finally
            {
                Console.WriteLine("\nPresione una tecla para salir");
                Console.ReadKey();
            }
        }
    }
}
