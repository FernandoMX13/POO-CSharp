/*
Programa de interfaz. Se pide una interfaz, en este caso se utliza maqinas expendedoras.
En este caso las maquinas expendedoras realizan las mismas acciones de
Despachar un producto, rellenarlas de producto y mostrar sus estatus
con ello en mente se crea una interfaz que haga presisamente una plantilla de estas acciones.
*/
using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpendedoraFrituras ef = new ExpendedoraFrituras(true,1,20,12.5);
            ExpendedoraCafe ec = new ExpendedoraCafe(false,20,4,5,14);
            ExpendedoraRefrescos er = new ExpendedoraRefrescos(true,5,40,15);
            Console.WriteLine("Probando objeto ExpendedoraFrituras");
            Console.WriteLine("**");
            ef.Despachar(20);
            Console.WriteLine("**");
            ef.Despachar(20);
            Console.WriteLine("**");
            Console.WriteLine(ef.Info());
            Console.WriteLine("**");
            ef.Rellenar();
            Console.WriteLine("**");
            ef.Despachar(10);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nProbando objeto ExpendedoraCafe");
            Console.WriteLine("**");
            ec.Despachar(20);
            Console.WriteLine("**");
            ec.Despachar(20);
            Console.WriteLine("**");
            Console.WriteLine(ec.Info());
            Console.WriteLine("**");
            ec.Rellenar();
            Console.WriteLine("**");
            ec.Despachar(10);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nProbando objeto ExpendedoraRefrescos");
            Console.WriteLine("**");
            er.Despachar(20);
            Console.WriteLine("**");
            er.Despachar(20);
            Console.WriteLine("**");
            Console.WriteLine(er.Info());
            Console.WriteLine("**");
            er.Rellenar();
            Console.WriteLine("**");
            er.Despachar(10);
            Console.WriteLine("----------------------------------------");
        }
    }
}
