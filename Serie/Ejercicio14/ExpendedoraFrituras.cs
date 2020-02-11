/*
Esta maquina es muy distinta a la maquina de cafe debido a que esta el producto despachado dependen de solo una unidad.
Por lo tanto solo requiere del tributo de producto para saber si puede despachar.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class ExpendedoraFrituras : IMaquinaExpendedora
    {
        private bool cambio;
        private int productos;
        private int maxProductos;
        private double precio;
        public bool Cambio
        {
            set {cambio = value; }
            get { return cambio; }
        }
        public int Productos
        {
            set { productos = value; }
            get { return productos; }
        }

        public int MaxProductos
        {
            set { maxProductos = value; }
            get { return maxProductos; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        //En este constructor se inicializa todos los atributos con los datos pasados al instanciarce.
        public ExpendedoraFrituras(bool cam, int prod, int maxProd, double prec)
        { 
            Cambio = cam;
            Productos = prod;
            MaxProductos = maxProd;
            Precio = prec;
        }
        //Para despachar depende de que se ingrese la cantidad de almenos una fritura y que existan frituras para despachar.
        public void Despachar(int dinero)
        {
            if (Productos > 0 && dinero >= Precio)
            {
                Console.WriteLine("Se despacha Frituras");
                productos--;
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
                    Console.WriteLine("No ingreso la cantida necesaria de dinero, el precio por fritura es de: {0:C}",Precio);
                }
                else
                    Console.WriteLine("Lo siento, no hay producto, espere a que la maquina sea rellenada");
            }
        }
        //Tambien se realiza la accion de rellenar la maquina en cualquier momento.
        public void Rellenar()
        {
            Console.WriteLine("Rellenando maquina.");
            Productos = maxProductos;
            Console.WriteLine("Maquina rellenada");
            Console.WriteLine(Info());
        }

        public string Info()
        {
            return string.Format("Esta es una maquina despachadora de frituras.\n Contiene:\t{0} frituras\n Su capacidad maxima de productos es:\t{1} frituras\n El precio por fritura:\t{2:C}\nDa cambio?\t{3}",Productos,MaxProductos,Precio,Cambio);
        }

    }
}
