using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales =
            {
                new Carnivoro("Leon"),
                new Herviboro("Jiraga")
            };
            Console.WriteLine("Lista de animales");
            foreach(Animal anima in animales)
            {
                Console.WriteLine(anima);
            }
            Lobo lobo = new Lobo("Lobezno");

            lobo.Cazar();

            (lobo as Carnivoro).Cazar();

            Pinguino pingu = new Pinguino("Tux");
            pingu.Cazar();
            (pingu as Carnivoro).Cazar();
        }
    }
}
