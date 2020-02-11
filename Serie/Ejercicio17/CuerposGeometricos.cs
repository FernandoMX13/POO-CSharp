/*
Clase padre el cual hereda el atributo de nombre, los metodos de Nombre para acceder al atributo del mismo nombre, y los metodos abstractos de volumen y area los
cuales los hijos haran polimorfismo para adaptarlos a su calculo de acuerdo a la figura.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    abstract class CuerposGeometricos
    {
        private string nombre;
        public string Nombre
        {
            get{ return nombre; }
            set { nombre = value; }
        }

        abstract public void volumen();
        abstract public void area();
    }
}
