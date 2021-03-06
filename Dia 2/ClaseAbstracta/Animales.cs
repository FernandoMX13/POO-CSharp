﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Lobo : Carnivoro
    {
        public Lobo(string nombre) :base(nombre) { }

        public void MuestraColmillos() 
        {
            Console.WriteLine("El lobo muestra sus colmillos");
        }

        public override void Cazar()
        {
            Console.WriteLine("El " + NombreComun + "usa sus colmillos para cazr.");
        }
    }

    class Pinguino : Carnivoro
    {
        public Pinguino(string nombre) : base(nombre) { }

        public void Deslizarse()
        {
            Console.WriteLine("Zump");
        }

        public void Cazar()
        {
            Console.WriteLine("El "+NombreComun+" usa su pico para cazar.");
        }
    }
}
