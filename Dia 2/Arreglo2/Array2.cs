using System;

class Program
{
    static void Main(string[] args)
    {
        int[] list = { 34, 234, 678, 234, 123, 10, 13 };
        int[] temp = new int[list.Length];

        Array.Copy(list, temp, list.Length);

        Console.WriteLine("Arreglo original");
        MostrarArreglo(list);

        //Invierte el arreglo.
        Array.Reverse(temp);
        Console.WriteLine("Arreglo invertido:");
        MostrarArreglo(temp);

        Array.Sort(temp);
        Console.WriteLine("Arreglo Ordenado");
        MostrarArreglo(temp);

        Console.WriteLine("Indice del numero 13 es :" + Array.IndexOf(temp, 13));

        Console.ReadKey();
    }

    static void MostrarArreglo(int[] arreglo)
    {
        foreach (int num in arreglo)
        {
            Console.WriteLine("{0} ", num);
            Console.WriteLine();
        }
    }

}



