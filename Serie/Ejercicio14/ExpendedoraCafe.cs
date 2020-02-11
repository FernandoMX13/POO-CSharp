/*
En esta clase de maquina para despachar un cafe se requieren distintos suministros como lo es los vasos, el agua y el cafe para preparar la bebidas, asi mismo
la maquina debe de tener una capacidad de estos insumos asi que tambien son un atributo, el cambio es si la maquina da cambio como tal.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class ExpendedoraCafe
    {
        private bool cambio;
        private double agua;
        private double maxAgua;
        private double cafe;
        private double maxCafe;
        private int vasos;
        private int maxVasos;
        private double precio;

        public bool Cambio
        {
            set { cambio = value; }
            get { return cambio; }
        }
        public double Agua
        {
            set { agua = value; }
            get { return agua; }
        }
        public double MAXAgua
        {
            set { maxAgua = value; }
            get { return maxAgua; }
        }
        public double Cafe
        {
            set { cafe = value; }
            get { return cafe; }
        }
        public double MAXCafe
        {
            set { maxCafe = value; }
            get { return maxCafe; }
        }

        public int Vasos
        {
            set { vasos = value; }
            get { return vasos; }
        }
        public int MAXVasos
        {
            set { maxVasos = value; }
            get { return maxVasos; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        //Construcctor se inicializa con los valores dados a excepcion de los insumos se considera que al crear la maquina esta esta llena en su totalidad.
        public ExpendedoraCafe(bool cam, double maxagu, double maxcaf, int maxvas, double prec)
        {
            Cambio = cam;
            Agua = maxagu;
            MAXAgua = maxagu;
            Cafe = maxcaf;
            MAXCafe = maxcaf;
            Vasos = maxvas;
            MAXVasos = maxvas;
            Precio = prec;
        }
        //Para despachar debe de ingresarse la cantidad de dinero de una bebida pero  tambien debe de existir un minimo de producto para despachar.
        public void Despachar(int dinero)
        {
            if (Cafe > 0.001 && Agua > 0.35 && Vasos > 0 && dinero >= precio)
            {
                Console.WriteLine("Se despacha un vaso de cafe");
                Cafe -= 0.001;
                Agua -= 0.35;
                Vasos--;
                if (cambio)
                {
                    Console.WriteLine("Su cambio es: {0:C}", dinero - Precio);
                }
                else
                    Console.WriteLine("Esta maquina no le da cambio, lo siento");
            }
            else
            {
                if (dinero < Precio)
                {
                    Console.WriteLine("No ingreso la cantida necesaria de dinero, el precio por cafe es de: {0:C}", Precio);
                }
                else
                    Console.WriteLine("Lo siento, no hay producto, espere a que la maquina sea rellenada");
            }
        }

        //La maquina se rellena en cualquier momento.
        public void Rellenar()
        {
            Console.WriteLine("Rellenando maquina.");
            Vasos = MAXVasos;
            Agua = MAXAgua;
            Cafe = maxCafe;
            Console.WriteLine("Maquina rellenada");
            Console.WriteLine(Info());
        }

        public string Info()
        {
            return string.Format("Esta es una maquina despachadora de cafe.\n Litros de agua actuales:\t{0:N4} de una capacidad maxima de {1}\n Kilos de cafe actuales:\t{2:N4} de una capacidad maxima de {3}\n Cantidad de vasos actuales:\t{4} de una capacidad maxima de {5}\n El precio por cafe es de:\t{6:C}\n Da cambio?{7}", Agua,MAXAgua,Cafe,MAXAgua,Vasos,MAXVasos, Precio, Cambio);
        }
    }
}
