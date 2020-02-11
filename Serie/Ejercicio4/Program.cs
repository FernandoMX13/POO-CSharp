/*
Programa que realiza la  serie de fibonacci hasta el n numero ingresado por el usuario.
*/

using System;

namespace Ejercicio4
{
    class Program
    {
        //Se hace la serie de Fibonacci de manera iterativa.
        static int fibonaccio(int num)
        {
            int primero = 0, segundo = 1, temp=0;
            if ((num != 1) && (num != 0))
            {
                for (int i = 1; i < num; i++)
                {	
	                temp = primero + segundo;
	                primero = segundo;
	                segundo = temp;
                }
                return temp;
            }
            else if (num == 1)
                return segundo;
            else
                return primero;
        }
        static void Main(string[] args)
        {
            try
            {
                //Se consigue la cantidad de numeros a mostrar.
                Console.WriteLine("Ingrese cuantos elementos de la serie de fibonacci desea:");
                uint limite = Convert.ToUInt32(Console.ReadLine());
                for (int i = 0; i < limite; i++)
                {
                    Console.Write("{0} ",fibonaccio(i));
                }
            }
            //Debido a que solo se espera un numeros se realiza la captura de excepciones en caso de que no se ingrese estos dato correctamente.
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
