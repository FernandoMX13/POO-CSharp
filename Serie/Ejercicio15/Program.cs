/*
Calculadora de dos numeros.
*/
using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string eleccion = "0";
            Double num1 = 0, num2 = 0;
            //Menu para salir se tiene que escoger la opcion 5 en otro caso no lo hace.
            Console.WriteLine("Bienvenido a la calculadora.\n");
            while (eleccion != "5")
            {
                Console.WriteLine("Escoja un opcion");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicacion");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Salir");
                Console.WriteLine("Escriba el numero de su eleccion");
                eleccion = Console.ReadLine();
                try
                {
                    switch (eleccion)
                    {
                        //En este caso se realiza la suma de dos numeros 
                        case "1":
                            Console.WriteLine("Esciba el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Esciba el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nResultado:\t{0} + {1} = {2}\n", num1, num2, num1 + num2);
                            break;
                        //En este caso se hace la resta de dos numeros
                        case "2":
                            Console.WriteLine("Esciba el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Esciba el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nResultado:\t{0} - {1} = {2}\n", num1, num2, num1 - num2);
                            break;
                        //En este caso se realiza la multiplicacion de dos numeros
                        case "3":
                            Console.WriteLine("Esciba el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Esciba el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nEl resultado:\t{0} * {1} = {2}\n", num1, num2, num1 * num2);
                            break;
                        //En este caso se reliza la division, debido a que los datos son del tipo double para hacer la excepcio de division entre cero
                        //se debe de hacer manual, en otro caso si se realiza la operacion dando por resultado 8 que es en realidad infinito.
                        case "4":
                            Console.WriteLine("Esciba el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Esciba el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 == 0) 
                            {
                                throw new System.DivideByZeroException();
                            }
                            Console.WriteLine("\nEl resultado:\t{0} / {1} = {2}\n", num1, num2, num1/num2);
                            break;
                        // Salir del programa.
                        case "5":
                            Console.WriteLine("Adios ;D");
                            Console.WriteLine("Presiones cualquier tecla para salir");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("\nOpcion invalida:\n");
                            break;
                    }
                }
                //Las excepciones que se tratan son las de insertar letras en lugar de numeros y la de division entre cero, el caso de numeros extremdamente grandes
                //no procede debido a que se usan doubles cuando se hace la division simplemente muestra infinito.
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    Console.WriteLine("ERROR: El ultimo dato ha sido ingresado erroneamente. Esta seguro que ingresa un numero?");
                    Console.WriteLine("Presiones cualquier tecla para salir");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
                catch (DivideByZeroException dbz)
                {
                    Console.WriteLine(dbz.Message);
                    Console.WriteLine("ERROR: Intentó dividir entre zero.");
                    Console.WriteLine("Presiones cualquier tecla para salir");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
        }
    }
}
