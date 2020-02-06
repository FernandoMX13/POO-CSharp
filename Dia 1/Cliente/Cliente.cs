using System;
using System.Collections.Generic;
using System.Text;

namespace Clase2
{
    class Cliente
    {
        string nombre;
        int edad;
        int cuenta;
        public static int contador = 0;
        double dinero;

        Random rm = new Random();

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public int Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0)
                    edad = 0;
                else
                    edad = value;
            }
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > dinero)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            dinero -= cantidad;
        }
        public void Despositar(Double cantidad)
        {
            dinero += cantidad;
        }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            dinero = 5000;
            cuenta = rm.Next(0, 100);
            contador = contador + 1;
        }

        public static string mensaje()
        {
            return "Welcome to C#'s course";
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}, Edad: {1}",nombre, edad);
        }

    }
}
