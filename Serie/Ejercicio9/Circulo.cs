/*
El circulo tiene como atributo su radio. Se hace uso de round y de pow de la clase math.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Circulo
    {
        private double Radio;

        public double radInfo
        {
            get { return Radio; }
            set { Radio = value; }
        }
        //Constructor que pide el radio
        public Circulo(double radio)
        {
            radInfo = radio;
        }
        //Claculo del area.
        public double area()
        {
            return Math.Round(Math.PI * Math.Pow(radInfo,2),2);
        }
    }
}
