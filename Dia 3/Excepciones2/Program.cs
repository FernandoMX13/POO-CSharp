using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese un valor para calcular una raiz cuadrada: ");
                double dato = Convert.ToInt32(Console.ReadLine());

                double resultado = RaizCuadrada(dato);

                Console.WriteLine("La raiz Cuadrada de {o} es {1}\n", dato, resultado);
                Console.ReadKey();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
                Console.WriteLine("Solo se permiten numeros");
            }
            catch (NegativeNumberException nne)
            {
                Console.WriteLine("\n"+nne.Message);
                Console.WriteLine("No se permiten numeros negativos");
            }
        }
        public static double RaizCuadrada(double numero)
        {
            if (numero < 0)
            {
                throw new NegativeNumberException("No pongas numeros negativos");
            }
            return Math.Sqrt(numero);
        }
    }
}
