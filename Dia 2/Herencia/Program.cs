using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Armando", 22);
            p.Saludar();
            Console.WriteLine(p.ToString());

            Empleado e = new Empleado("Antonio", 25, "Gerente general de asuntos genrales", 13000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e.ToString());

            Persona p1 = new Persona("Xotla", 22);
            Persona p2 = new Persona("Rodolofo", 22);

            Persona[] gentes = new Persona[4];

            gentes[0] = p;
            gentes[1] = p1;
            gentes[2] = p2;
            gentes[3] = e;

            Console.WriteLine();
            Console.WriteLine("Lista de personas que son empleados");

            foreach(var perz in gentes)
            {
                if(per is Empleado)
                {
                    Console.WriteLine(per.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
