using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int proyecto, tareas, participaciones;
            string nombre;
            Console.WriteLine("Ingrese el numero de alumnos a calificar");
            int num = Convert.ToInt32(Console.ReadLine());
            Alumno [] estudiantes = new Alumno[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Ingrese el nombre del alumno:");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la calificacion del proyecto:");
                proyecto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de tareas entregadas:");
                tareas= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de participaciones:");
                participaciones = Convert.ToInt32(Console.ReadLine());
                estudiantes[i] = new Alumno(nombre,proyecto,tareas,participaciones);
            }
            Console.WriteLine("________________________________________________");
            foreach (var alu in estudiantes)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine(alu.ToString());
                Console.WriteLine("Calificacion Final:\t{0}",calculadora(alu));
            }
            Console.WriteLine("***********************************************");
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadKey();
        }

        static double calculadora (Alumno revision)
        {
            double res;
            res = revision.Proyecto * 0.6 + (revision.Tareas * 0.8);
            if (revision.Participaciones > 5)
                res += 0.8;
            if (res > 10)
                res = 10;
            if (res < 5)
                res = 5;
            return res;
        }
    }
}
