/*
En este progrma se hace la prueba de la clase Auto.
*/
using System;

namespace Ejercicio8
{
    class Program
    {
        static void mostrarMetodos(Auto car)
        {
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("Estado inicial del vehiculo");
            Console.WriteLine(car.info());
            Console.WriteLine();
            //Se hace uso de la funcio de cargar conbustible.
            car.recargarCombustible(47);
            Console.WriteLine();
            car.recargarCombustible(20);
            Console.WriteLine();
            //Se prueba funcion de Viajar.
            car.viajar(100);
            Console.WriteLine();
            Console.WriteLine(car.info());
            Console.WriteLine();
            //Se hace uso de la funcion reset
            car.reset();
            Console.WriteLine();
            //Se muestra la info del auto.
            Console.WriteLine(car.info());
            Console.WriteLine();
            Console.WriteLine("_________________________________________________________________");
        }
        static void Main(string[] args)
        {
            //Se crean los objetos.
            Auto a1 = new Auto("Volkswagen", "Bocho");
            Auto a2 = new Auto("Honda", "Civic Type R", 14,47,0,47);
            Auto a3 = new Auto("Chevrolet", "Blazer '98", 5.03,68,185000,30);
            //Se meten los objetos a un arreglo para asi usar una funcion que los imprime y no repetir codigo.
            Auto[] autos = { a1, a2, a3 };
            foreach (var vehiculo in autos) 
            {
                mostrarMetodos(vehiculo);
            }
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
