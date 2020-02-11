using System;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> pila = new Stack<double>(10);

            pila.Push(5.5);
            pila.Push(10);

            double x = pila.pop();
            double y = pila.pop();

            Console.WriteLine("x: {0}, y: {1}",x,y);
            Stack<Tortilla> stack = new Stack<Tortilla>();
            stack.Push(new Tortilla());
            stack.Push(new Tortilla());

            Console.WriteLine(stack.pop().color);
            Console.WriteLine(stack.pop().color);
        }
    }
}
