/*
Los cuatro pilares de POO este programa los implementa.
Herencia. Se tiene  una clase padre que es Cuerpos geometricos el cual le hereda a sus hijos
El atributo de nombre y los metodos de Area y volumen.
Polimorfismo. Este se ve en los metodos heredado debido a que estos se realian de manera distintas en cada clase que lo hereda.
Encapsulamient. Los atributos solo son accecibles desde dentro de las misma clase mediante algun metodo.
Abstraccion. Las clases en si abstraen algo mas complejo debido a que una figura puede tener un sin fin de caracteristicas especificas
pero las clases lo abstraeb a una solo forma decrita por su area y volumen.
*/

using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Cubo cubo = new Cubo("cubo",5);
            Console.WriteLine("Probando la clase Cubo");
            cubo.area();
            cubo.volumen();

            Esfera esfe = new Esfera("esfera", 3);
            Console.WriteLine("\nProbando la clase Esfera");
            esfe.area();
            esfe.volumen();
        }
    }
}
