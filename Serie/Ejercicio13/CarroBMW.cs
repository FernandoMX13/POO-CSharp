/*
Clase CarroBMW Con los atributos y metodos heredados de la clase Carro se agrega el atributo Turbo y Modelo ademas del metodo info turbo como lo estipula el documento
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class CarroBMW : Carro
    {
        private string modelo;
        private bool turbo;

        public bool Turbo
        {
            get { return turbo; }
            set { turbo = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public CarroBMW(double weight, double height) : base(weight,height)
        {
            Altura = height;
            Peso = weight;
            Modelo = "BMW";
            Encendido = false;
            Turbo = true;
        }

        public string infoTurbo()
        {
            if (turbo)
                return string.Format("Tengo turbo");
            else
                return string.Format("No Tengo turbo");
        }

        public override string ToString()
        {
            return string.Format("{0}\nEl peso es: {1} \n La altura es: {2}\n El modelo es:{3}",infoTurbo(), Peso, Altura, Modelo); ;
        }
    }
}
