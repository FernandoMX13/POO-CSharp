using System;

public class Program
{
	static void Main (String[] args)
    {
        persona p_1 = new persona("Fernando", 24);
        persona p_2 = new persona("Luis", 21);
        persona p_3 = new persona("Alberto", 23);
        persona p_4 = new persona("Alberto", 23);

        Console.WriteLine("Referencias p1 y p2 son iguales?");
        Console.WriteLine(p_1 == p_2);

        Console.WriteLine("Referencias p2 y p3 son iguales?");
        Console.WriteLine(p_2 == p_3);

        Console.WriteLine("Referencias p3 y p4 son iguales?");
        Console.WriteLine(p_3 == p_4);


        Console.WriteLine("Objetos p1 y p2 son iguales?");
        Console.WriteLine(p_1.equals(p_2));

        Console.WriteLine("Objetos p2 y p3 son iguales?");
        Console.WriteLine(p_2.equals(p_3));

        Console.WriteLine("Objetos p3 y p4 son iguales?");
        Console.WriteLine(p_3.equals(p_4));

        Console.ReadKey();
    }
}
