/*
Clase CarroVW con los atributos y metodos de la clase carro al igual que la clase CarroBMW se agreagro atributos adicionales como lo dice en el documento.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class CarroVW : Carro
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
        public CarroVW(double weight, double height) : base(weight, height)
        {
            Altura = height;
            Peso = weight;
            Modelo = "VW";
            Encendido = false;
            Turbo = false;
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
            return string.Format("{0}\nEl peso es: {1} \n La altura es: {2}\n El modelo es:{3}", infoTurbo(), Peso, Altura, Modelo); ;
        }
    }
}
