/*
Clase de CuentaBancaria.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class CuentaBancaria
    {
        //La cuenta cuenta con los atributos de nombre y de saldo
        private string name;
        private double balance;

        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }
        //Se hace la comprobcion que el saldo sea positivo
        public double Saldo
        {
            get { return balance; }
            set 
            {
                if (value < 0)
                    Console.WriteLine("No se acepta saldos negativos");
                else
                    balance = value;
            }
        }
        //La creacion de un objeto puede ser de dos maneras: Ingresando el saldo y el nombre o solo el nombre.
        public CuentaBancaria(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
            Console.WriteLine(mostrarInformacion());
        }

        public CuentaBancaria(string nombre)
        {
            Nombre = nombre;
            Saldo = 15000;
            Console.WriteLine(mostrarInformacion());
        }
        //Muestra la informacion de la cuenta.
        public string mostrarInformacion()
        {
            return string.Format("Informacion actual de la cuenta:\n  Nombre:\t{0}\n  Saldo\t{1:C}\n",name,balance);
        }
        //Hace los depositos hacia la cuenta.
        public void Depositar(double cantidad) 
        {
            balance += cantidad;
            Console.WriteLine("\nTransaccion exitosa\n  Saldo actual:\t{0:C}", balance);
        }
        //Retira dinero de la cuenta si la cantidad a retirar es mayor al saldo entonces no se efectua.
        public void Retirar(double cantidad)
        {
            if (cantidad > balance)
                Console.WriteLine("Saldo insuficiente para realizar la operacion");
            else
            {
                balance -= cantidad;
                Console.WriteLine("\nTransaccion exitosa\n  Saldo actual:\t{0:C}", balance);
            }
        }
    }
}
