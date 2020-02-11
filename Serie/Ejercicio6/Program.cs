/*
Programa que prueba la clase de cuenta bancaria.
*/
using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double retiro = 100000, deposito = 10000;
            //Se crean los objetos-
            CuentaBancaria c1 = new CuentaBancaria("Pedro Perez Perez", 1234567.89);
            CuentaBancaria c2 = new CuentaBancaria("Jose Lopez Lopez");
            //Se pruebam los metodos de cada clase.
            Console.WriteLine("_______________________________");
            Console.WriteLine("Probando cuenta de {0}", c1.Nombre);
            Console.WriteLine("Retirando {0:c}", retiro);
            c1.Retirar(retiro);
            Console.WriteLine(c1.mostrarInformacion());
            Console.WriteLine("Depositando {0:c}", deposito);
            c1.Depositar(deposito);
            Console.WriteLine(c1.mostrarInformacion());

            Console.WriteLine("_______________________________");

            Console.WriteLine("Probando cuenta de {0}", c2.Nombre);
            Console.WriteLine("Retirando {0:c}", retiro);
            c2.Retirar(retiro);
            Console.WriteLine(c2.mostrarInformacion());
            Console.WriteLine("depositando {0:c}", deposito);
            c2.Depositar(deposito);
            Console.WriteLine(c2.mostrarInformacion());
            Console.WriteLine("_______________________________");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
