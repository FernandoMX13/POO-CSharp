/*
El trapecio circular tiene de atributos un rafio interio y otro exterio asi como un angulo estos son utiles para realizar el calculo de su area.
Se hace uso de pow y de truncate que son metodos de la libreria math.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class TrapecioCircular
    {
        private double RadioMayor;
        private double RadioMenor;
        private double Angulo;

        public double radMaydInfo
        {
            get { return RadioMayor; }
            set { RadioMayor = value; }
        }

        public double radmenInfo
        {
            get { return RadioMenor; }
            set { RadioMenor = value; }
        }

        public double ang
        {
            get { return Angulo; }
            set { Angulo = value; }
        }
        //Constructor que pide los radios menor y mayor asi como el angulo
        public TrapecioCircular(double radioM, double radiom,double angulo)
        {
            radMaydInfo = radioM;
            radmenInfo = radiom;
            ang = angulo;
        }
        //Aqui se hace el calculo del area.
        public double area()
        {
            return Math.Truncate(((Math.PI * (Math.Pow(radMaydInfo, 2) - Math.Pow(radmenInfo, 2)) * ang) / 360) * 100) / 100;
        }
    }
}
