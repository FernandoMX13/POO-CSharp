/*
Clase IMaquinaExpendedora en la cual se crea la interfaz con los metodos de DEspachar, Rellenar e Info
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    interface IMaquinaExpendedora
    {
        void Despachar(int dinero);
        void Rellenar();
        string Info();
    }
}
