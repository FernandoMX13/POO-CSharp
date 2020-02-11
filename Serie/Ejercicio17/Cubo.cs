/*
Al igual que la clase Esfera la clase Cubo hereda de la clase CuerposGeometrcios pero implementa su propio
atributo de Artista y cambian los metodos de area y de valumen para que estos se adaoten a su propio calculo de un cubo.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    class Cubo:CuerposGeometricos
    {
        private double arista;
        public double Arista
        {
            get { return arista; }
            set { arista = value; }
        }
        public Cubo(string nom, double aris)
        {
            Nombre = nom;
            Arista = aris;
        }
        public override void area()
        {
            Console.WriteLine("El area de {0} es : {1:N2}", Nombre, 6 * Math.Pow(Arista, 2));
        }
        public override void volumen()
        {
            Console.WriteLine("El volume de {0} es : {1:N2}", Nombre, Math.Pow(Arista, 3));
        }
    }
}
