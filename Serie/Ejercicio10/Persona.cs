/*
Clase persona.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    class Persona
    {
        private string Name;
        private int Age;
        private double Height;
        private double Weight;

        public string Nombre
        {
            get { return Name; }
        }

        public int Edad
        {
            get { return Age; }
        }

        public double Altura
        {
            get { return Height; }
        }

        public double Peso
        {
            get { return Weight; }
        }

        public Persona(String nombre, int edad, double altura, double peso)
        {
            Name = nombre;
            Age = edad;
            Height = altura;
            Weight = peso;
        }

        //Este metodo nos muestra la informacion de la persona
        public override string ToString()
        {
            return string.Format(" {0}\n Edad:\t{1} años\n Altura:\t{2} m\n Peso:\t{3} kg", Nombre, Edad, Altura,Peso);
        }

        //Este metodo realiza el calculo de IMC y da una respuesta del estado de la perona
        public void imc()
        {
            if (Edad < 20)
            {
                Console.WriteLine("La persona es menor de 20 años, se considera un niño o adolecente por lo tanto el calculo de su IMC depende del sexo y edad especifica no podemos realizar el calculo");
            }
            else 
            {
                double imc = Peso / Math.Pow(Altura, 2);
                if (imc <= 18.5)
                    Console.WriteLine("Su indice de masa corpora es {0:N2} por lo tanto la persona se encuentra bajo de peso.",imc);
                else if (imc <= 25.0 && imc > 18.5)
                    Console.WriteLine("Su indice de masa corpora es {0:N2} por lo tanto la persona se encuentra en peso normal.", imc);
                else if (imc <= 29.9 && imc > 25.5)
                    Console.WriteLine("Su indice de masa corpora es {0:N2} por lo tanto la persona se encuentra en sobrepeso.", imc);
                else
                    Console.WriteLine("Su indice de masa corpora es {0:N2} por lo tanto la persona se encuentra en obesidad.", imc);
            }
        }

        //Este metodo nos dice si la persona es mayor de edad.
        public void mayorEdad()
        {
            if (Edad >= 18)
                Console.WriteLine("La persona es considerada mayor de edad segun las leyes mexicanas");
            else
                Console.WriteLine("La persona es considerada menor de edad segun las leyes mexicanas");
        }
    }
}
