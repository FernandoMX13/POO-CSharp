using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main()
        {
            var anonimo = new { Modelo = "Bocho", Precio = 80000, Placa = "45rt65" };
            Console.WriteLine("Datos");
            Console.WriteLine(anonimo.Modelo);
            Console.WriteLine(anonimo.Placa);
            Console.WriteLine(anonimo.Precio);
            Console.ReadKey();
        }
    }
}
