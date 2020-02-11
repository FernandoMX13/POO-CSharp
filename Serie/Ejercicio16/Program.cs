/*
Programa que usa polimorfismo. En este codigo solamente se hace la comprobacion de estos, como tal se realiza ya que los mismos metodos en clases heredadas
de una clase abstracta realizan funciones distintas que es un ejemplo de polimorfismo que es el relizar distintas acciones a pesar de que el metodo sea el mismo.
*/

using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Latrans Coyote = new Latrans();
            Lopus Lobo = new Lopus();
            Familiaris Perro = new Familiaris();
            Console.WriteLine("Probando el objeto Lobo");
            Console.WriteLine(Lobo.NombreCientifico);
            Console.WriteLine(Lobo.consigueComida);
            Console.WriteLine(Lobo.tipoDeComida);

            Console.WriteLine("\nProbando el objeto Coyote");
            Console.WriteLine(Coyote.NombreCientifico);
            Console.WriteLine(Coyote.consigueComida);
            Console.WriteLine(Coyote.tipoDeComida);

            Console.WriteLine("\nProbando el objeto Perro");
            Console.WriteLine(Perro.NombreCientifico);
            Console.WriteLine(Perro.consigueComida);
            Console.WriteLine(Perro.tipoDeComida);
        }
    }
}
