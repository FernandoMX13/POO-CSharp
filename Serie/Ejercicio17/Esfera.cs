/*
Esta clase hereda de cuerposGeometricos requiere del atributo de Radio que es propio de la clase. Tambien cambia la forma de calcular
el area y el volumen.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    class Esfera : CuerposGeometricos
    {
        private double radio;
        public double Radio 
        {
            get { return radio; }
            set { radio = value; }
        }
        public Esfera(string nom,double rad)
        {
            Nombre = nom;
            Radio = rad;
        }
        public override void area ()
        {
            Console.WriteLine("El area de {0} es : {1:N2}",Nombre,4*Math.PI*Math.Pow(Radio,2));
        }
        public override void volumen()
        {
            Console.WriteLine("El volume de {0} es : {1:N2}", Nombre, (4/3) * Math.PI * Math.Pow(Radio, 3));
        }
    }
}
