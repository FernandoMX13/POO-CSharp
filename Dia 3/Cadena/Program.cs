using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenacion
            Console.WriteLine("Hello"+" World!");
            Console.WriteLine(string.Concat("Hola","Mundo"));

            string cadena = "Esta es una cadema de prueba";

            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: " + cadena.Length);
            Console.WriteLine("Cadena mayuscula: "+ cadena.ToUpper());
            Console.WriteLine("Cadena minusculas: " + cadena.ToLower());
            Console.WriteLine("Replace: "+cadena.Replace(" ",""));
            Console.WriteLine("Caracter en indice 0: "+ cadena[0]);
            Console.WriteLine("Substrings: "+ cadena.Substring(1,8));
            Console.WriteLine("Cadena contiene \"es\"? "+ cadena.Contains("es"));

            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;

            string ejemp = string.Format("Hay {0} naranjas, {1} platanos, {2} manzanas", naranjas,platanos,manzanas);

            Console.WriteLine(ejemp);

            Console.WriteLine("PI: {0:0.00}",Math.PI);

            Console.WriteLine("Numeros: {0:N}", 126);
            Console.WriteLine("Notacion cientifica: {0:E}", 126);
            Console.WriteLine("Dinero: {0:C}", 126);
            Console.WriteLine("Porcentaje: {0:P}", 126);
            Console.WriteLine("Hexadecimal: {0:X}", 126);

            Console.ReadKey();
        }
    }
}
