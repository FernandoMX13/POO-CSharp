using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Convert.ToInt32 genera FormatException
                Console.WriteLine("Ingrese numerador: ");
                double numerador = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese denominador: ");
                double denominador = Convert.ToInt32(Console.ReadLine());

                //Laz division entre cero genera una exception DivideByZeroException
                double resultado = numerador / denominador;

                Console.WriteLine("\nRsultado entre : {0} / {1} = {2}", numerador, denominador, resultado);

                Console.ReadKey();
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Ingrese solo numeros");
            }
            catch (DivideByZeroException divbyzero)
            {
                Console.WriteLine("\n" + divbyzero.Message);
                Console.WriteLine("No no se puede dividir entre cero");
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }

        }
    }
}
