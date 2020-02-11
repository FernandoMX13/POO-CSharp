/*
Latrans es hijo de canis lo cual hereda los mismos metodos pero por polimorfismos los puede adaptar a la manera que este lo requiera.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Latrans : Canis
    {
        public Latrans() : base()
        {
            NombreCientifico = "Canis Latrans";
        }
        public override string consigueComida
        {
            get { return "Yo cazo mi alimento de manera solitaria prefiero no estar en manada"; }
        }
        public override string tipoDeComida
        {
            get { return "Soy omnivoro."; }
        }
    }
}
