using System;




class Program
{
    static void MostrarArreglo(int [] arreglo)
    {
        foreach(int num in arreglo)
        {
            Console.WriteLine("{0} ",num);
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.WriteLine("Tamaño del arreglo");
        int tam = Convert.ToInt32(Console.ReadLine());

        //Definiendo arreglo

        int[] numeros = new int[tam];
        for(int i=0; i<numeros.Length; i++)
        {
            Console.WriteLine("Indice: {0}", i);
            numeros[i] = Convert.ToInt32(Console.ReadLine());

        }

        //Mostrando datos

        Console.WriteLine("Los datos ingresados son:");
        MostrarArreglo(numeros);
        Console.ReadLine();

    }
}

