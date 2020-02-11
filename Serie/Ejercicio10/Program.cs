/*
Programa que utiliza el objeto persona y hace uso de sus metodos.
*/
using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //Seingresan los datos de la persona. Se le pregunta la usuario
                Console.WriteLine("Ingrese el nombre de la persona:");
                string nom = Console.ReadLine();
                Console.WriteLine("Ingres la edad de la persona:");
                int anios = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingres la estatura en metros (m) de la persona:");
                double estatura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingres el peso en kilogramos (kg) de la persona:");
                double peso = Convert.ToDouble(Console.ReadLine());
                //Se crear el objeto con los datos solicitados
                Persona per = new Persona(nom,anios,estatura,peso);
                //ToString muestra informcion general de la person.
                Console.WriteLine(per.ToString());
                //mayorEdad nos dice si la persona es mayor de edad
                per.mayorEdad();
                //imc calcula el indice de masa corporal de la persona y nos dice su estado.
                per.imc();
                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
            }
            //Si un dato es ingresado de manera erronea salta una escepcion.
            catch (FormatException)
            {
                Console.WriteLine("\nERROR: El numero ingresado no esta en el formato completo.");
                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
            }
        }
    }
}
