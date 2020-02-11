/*
Lopus y latrans heredan del mismo padre que es canis solo que sus implementaciones de los metodos abstractos son distintos entre ellos.
Y en el caso de lopus su hijo no implenta los metodos de la misma forma.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Lopus : Canis
    {
        public Lopus() : base()
        {
            NombreCientifico = "Canis Lopus";
        }
        public override string consigueComida
        {
            get { return "Yo cazo mi alimento en manada o de manera solitaria,"; }
        }
        public override string tipoDeComida
        {
            get { return "Soy carnivoro"; }
        }
    }
}
