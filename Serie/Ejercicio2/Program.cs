/*
Programa que realiza la imprecion de los numeros naturales del 1 al 100 e imprime clap si alguno de los digitos es multiplo de alguno de los numeros
ingresados por el usuario o bien contiene alguno de estos.
*/

using System;

namespace Eje1
{
    class Program
    {
        //Esta funcion realiza el conteo de los naturales y hace las comparaciones para imprimir clap
        static void NaturalCount(uint limit,uint num1, uint num2)
        {
            Console.WriteLine("Los numeros del 1 al {0} son: ", limit);
            for (int i = 1; i <= limit; i++)
            {
                if (i % num1 == 0 || i % num2 == 0)
                    Console.Write("Clap ");
                else if (Convert.ToString(i).Contains(Convert.ToString(num1)) || Convert.ToString(i).Contains(Convert.ToString(num2)))
                    Console.Write("Clap ");
                else
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            try
            {
                //Se piden los numeros y se validan que esten entre el 1 al 9
                Console.WriteLine("Ingrese el primer multiplo este debe de estar ente el 1 el 9:");
                uint num1 = Convert.ToUInt32(Console.ReadLine());
                while (num1 < 1 || num1 > 9) 
                {
                    Console.WriteLine("\nEl numero ingresado debe estar entre el 1 y el 9 !!!");
                    Console.WriteLine("Ingrese de nuevo el primer multiplo:");
                    num1 = Convert.ToUInt32(Console.ReadLine());
                }
                Console.WriteLine("\nIngrese el seguno multiplo este debe de estar ente el 1 el 9:");
                uint num2 = Convert.ToUInt32(Console.ReadLine());
                while (num2 < 1 || num2 > 9)
                {
                    Console.WriteLine("\nEl numero ingresado debe estar entre el 1 y el 9 !!!");
                    Console.WriteLine("Ingrese de nuevo el segundo multiplo:");
                    num2 = Convert.ToUInt32(Console.ReadLine());
                }
                //Como el programa es una reutilizacion del ejercicio 1 se necesita colocar como limite el 100
                uint limite = 100;
                NaturalCount(limite, num1, num2);
            }
            //Se captura la excepciones que pueden ocurrir al ingresar los numeros.
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
