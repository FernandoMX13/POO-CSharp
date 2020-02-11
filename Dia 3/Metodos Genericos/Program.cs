using System;

namespace MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            double[] doubleArray = { 1.1, 2.2,3.4,123.321};
            char[] charArray = { 'H','O','L','A'};

            Console.WriteLine("IntArray Contien");
            MuestraArreglo(intArray);

            Console.WriteLine("doubleArray Contien");
            MuestraArreglo(doubleArray);

            Console.WriteLine("charArray Contien");
            MuestraArreglo(charArray);

            Console.ReadKey();
        }

        public static void MuestraArreglo<T>(T[] inputArray) 
        { 
            foreach(T elemento in inputArray)
            {
                Console.Write(elemento + " ");
            }

            Console.WriteLine();
        }
    }
}
