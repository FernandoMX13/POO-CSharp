/*
Esta clase es la encargada de realizar el polimorfismo esto mediante su naturaleza de ser abstracto.
Lo que van a tener en comun sus hijo es el de nombre cientifico pero el que puede variar segun se requiere
son los metodos de consigueComida y el de tipoDeComida esto es debido a que no todos los caninos 
comen y consiguen la misma comda.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    abstract class Canis
    {
        private string nombreCien;

        public string NombreCientifico
        {
            get { return nombreCien; }
            set { nombreCien = value; }
        }

        public abstract string consigueComida
        {
            get;
        }
        public abstract string tipoDeComida
        {
            get;

        }
        public Canis()
        {
            NombreCientifico = "Canis";
        }
    }
}
