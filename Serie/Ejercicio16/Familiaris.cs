/*
Esta clase es hija de la clase Lopus que a subes es hija de canis por lo tanto esta clase de familiaris tambien tiene
los metodos de Consigue comida y la de tipo de comida solo que su implementacion es distinta a la de su padre.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Familiaris : Lopus
    {
        public Familiaris() : base() 
        {
            NombreCientifico = "Canis Lopus Familiaris";
        }
        public override string consigueComida
        { 
            get { return "Yo espero a que un humano me alimente :D"; }
        }
        public override string tipoDeComida 
        {
            get { return "Soy omnivoro pero es mejor para mi comer croquetas"; }
        }
    }
}
