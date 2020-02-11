/*
Clase padre con los metodo y atributos que se pidieron en el documento.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class Carro
    {
        private double peso;
        private double altura;
        private bool encendido;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public bool Encendido
        {
            get { return encendido; }
            set { encendido = value; }

        }
        public Carro(double weight, double height) 
        {
            peso = weight;
            altura = height;
            encendido = false;
        }

        public void encender()
        {
            Encendido = true;
            Console.WriteLine("El carro se ha encendido");
        }
        public void apagar()
        {
            Encendido = false;
            Console.WriteLine("El carro se ha apagado");
        }
        public void estado()
        {
            if (Encendido == true)
                Console.WriteLine("El carro esta encendido");
            else
                Console.WriteLine("El carro esta apagado");
        }

        public override string ToString()
        {
            return string.Format("El peso es: {0} \n La altura es: {1}",Peso,Altura);
        }
    }
}
