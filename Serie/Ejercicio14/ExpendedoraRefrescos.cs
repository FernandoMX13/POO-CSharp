/*
Este maquina es muy parecidad a al de frituras con la excepcion de que esta cambian ciertos mensajes debido a que el producto que despacha es distinto.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class ExpendedoraRefrescos : IMaquinaExpendedora
    {
        private bool cambio;
        private int productos;
        private int maxProductos;
        private double precio;
        public bool Cambio
        {
            set { cambio = value; }
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
        public ExpendedoraRefrescos(bool cam, int prod, int maxProd, double prec)
        {
            Cambio = cam;
            Productos = prod;
            MaxProductos = maxProd;
            Precio = prec;
        }
        public void Despachar(int dinero)
        {
            if (Productos > 0 && dinero >= Precio)
            {
                Console.WriteLine("Se despacha refresco");
                productos--;
                if (cambio)
                {
                    Console.WriteLine("Su cambio es: {0:C}", dinero - Precio);
                }
                else
                {
                    if (dinero < Precio)
                    {
                        Console.WriteLine("No ingreso la cantida necesaria de dinero, el precio por refresco es de: {0:C}", Precio);
                    }
                    else
                        Console.WriteLine("Lo siento, no hay producto, espere a que la maquina sea rellenada");
                }
            }
            else
            {
                if (dinero < Precio)
                {
                    Console.WriteLine("No ingreso la cantida necesaria de dinero, el precio por refresco es de: {0:C}", Precio);
                }
                else
                    Console.WriteLine("Lo siento, no hay producto, espere a que la maquina sea rellenada");
            }
        }

        public void Rellenar()
        {
            Console.WriteLine("Rellenando maquina.");
            Productos = maxProductos;
            Console.WriteLine("Maquina rellenada");
            Console.WriteLine(Info());
        }

        public string Info()
        {
            return string.Format("Esta es una maquina despachadora de refrescos.\n Contiene:\t{0} refrescos\n Su capacidad maxima de productos es:\t{1} refrecos\n El precio por refresco:\t{2:C}\nDa cambio?\t{3}", Productos, MaxProductos, Precio, Cambio);
        }

    }
}
