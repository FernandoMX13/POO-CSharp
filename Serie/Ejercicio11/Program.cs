/*
Programa que realiza operaciones de matrices de nxn.
*/
using System;

namespace Ejercicio11
{
    class Program
    {
        //Esta funcion realiza la suma y la resta necesita de las matrices que usara la dimension y un booleando que ondica si se hace una suma (true) o una resta (false)
        static void sumRestMat(double[,] m1, double[,] m2, uint n, bool oper)
        {
            //Matriz que alberga el resultado
            double[,] res = new double[n, n];
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        res[i, j] = 0;
                        if (oper)
                            res[i, j] = m1[i, j] + m2[i, j];
                        else
                            res[i, j] = m1[i, j] - m2[i, j];
                    }
                }
                //Una vez terminado lo muestra usando una funcion que imprime matrices
                imprimirMat(res, n,3);
            }
        }
        //Esta funcion realiza la multiplicacion que es un tanto distinta que la suma o la resta pero tambien necesita los mismos parametros excepto por el booleano
        static void multiMat(double[,] m1, double[,] m2, uint n)
        {
            double[,] res = new double[n, n];
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        res[i, j] = 0;
                        for (int k = 0; k < n; k++)
                            res[i, j] += m1[i, k] * m2[k, j];
                    }
                }
                imprimirMat(res, n,3);
            }
        }
        //Funcion que imprime matrices requiere de una matriz, la dimencio de esta y un valor que define si imprimira un mensaje de acuero si es la matriz 1. 2 o el del resultado.
        static void imprimirMat(double[,] mat, uint n, int primero)
        {
            if (primero == 1)
                Console.WriteLine("\nMatriz 1");
            else if (primero == 2)
                Console.WriteLine("\nMatriz 2");
            else
                Console.WriteLine("\nMatriz Resultado");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i,j]);
                    if (j != n - 1)
                        Console.Write(" | ");
                }
                Console.WriteLine();
                for (int k = 0; k < n; k++)
                    Console.Write("___");
                Console.WriteLine();
            }
        }
        //Esta funcion permite guardar los datos de cada matiz con la que se operaran.
        static double [,] creacionMat(uint n, bool primero)
        {
            if(primero)
                Console.WriteLine("\nIngresando Matriz 1");
            else
                Console.WriteLine("\nIngresando Matriz 2");
            double[,] mat = new double[n, n];
            for (int i = 0; i < n; i++) 
            {
                try
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Ingrese el valor de la posicion {0},{1}:", i + 1, j + 1);
                        mat[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Debe ingresar un numero");
                    Environment.Exit(1);
                }

            }    
            return mat;
        }
        static void Main(string[] args)
        {
            string eleccion = "0";
            uint n=0;
            double[,] mat1, mat2;
            //Menu
            Console.WriteLine("Calculadora de matrices\n");
            while (eleccion != "4")
            {
                Console.WriteLine("Escoja un opcion");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicacion");
                Console.WriteLine("4) Salir");
                Console.WriteLine("Escriba el numero de su eleccion");
                eleccion = Console.ReadLine();
                switch (eleccion)
                {
                    //Caso de suma de Matrices se pide la dimension n, se llenan las matrices y se procede a realizar la suma
                    case "1":
                        Console.WriteLine("\nSuma de Matrices");
                        Console.WriteLine("Ingrese de que dimension seran las matrices");
                        try
                        {
                            n = Convert.ToUInt32(Console.ReadLine());
                        }
                        //No se permite valores que no sean enteros positivos
                        catch (FormatException)
                        {
                            Console.WriteLine("ERROR: El numero ingresado debe de ser un entero sin signo");
                            Console.WriteLine("Presiona cualquier tecla para salir.");
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                        //Creacion de la matriz 1
                        mat1 = creacionMat(n, true);
                        //Creacion de la matriz 2
                        mat2 = creacionMat(n, false);
                        //Se imprimen ambas matrices.
                        imprimirMat(mat1, n, 1);
                        imprimirMat(mat2, n, 2);
                        //operacion y resultado, con true se realiza una suma
                        sumRestMat(mat1, mat2, n, true);
                        break;
                    case "2":
                        //Sucede lo mismo que con la suma.
                        Console.WriteLine("\nResta de Matrices");
                        Console.WriteLine("Ingrese de que dimension seran las matrices");
                        try
                        {
                            n = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("ERROR: El numero ingresado debe de ser un entero sin signo");
                            Console.WriteLine("Presiona cualquier tecla para salir.");
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                        mat1 = creacionMat(n, true);
                        mat2 = creacionMat(n, false);
                        imprimirMat(mat1, n, 1);
                        imprimirMat(mat2, n, 2);
                        //operacion y resultado con false realiza la resta.
                        sumRestMat(mat1, mat2, n, false);
                        break;
                    case "3":
                        //Es el mismo caso que con la suma y la resta solo cambia la funcion que realiza la operacion
                        Console.WriteLine("\nMultiplicacion de Matrices");
                        Console.WriteLine("Ingrese de que dimension seran las matrices");
                        try
                        {
                            n = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("ERROR: El numero ingresado debe de ser un entero sin signo");
                            Console.WriteLine("Presiona cualquier tecla para salir.");
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                        mat1 = creacionMat(n,true);
                        mat2 = creacionMat(n,false);
                        imprimirMat(mat1, n,1);
                        imprimirMat(mat2, n,2);
                        multiMat(mat1, mat2,n);
                        break;
                    case "4":
                        Console.WriteLine("Adios ;D");
                        Console.WriteLine("Presiona cualquier tecla para salir.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nOpcion invalida:\n");
                        break;
                }


            }

        }
    }
}
