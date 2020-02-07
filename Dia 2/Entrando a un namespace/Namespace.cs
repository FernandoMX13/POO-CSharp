using System;

namespace MiNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro del Mispace");
        }
    }
}

class uno
{
    public void metodo()
    {
        Console.WriteLine("Afuera del mispace");
    }
}

namespace Namespace
{
    class program
    {
        static void Main()
        {
            MiNamespace.Clase1 obj1 = new MiNamespace.Clase1();
            uno obj2 = new uno();
            obj1.Metodo();
            obj2.metodo();
        }
    }
}