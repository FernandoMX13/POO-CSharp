/*
Programa del becarioMart
*/
using System;
using System.Collections.Generic;

namespace Ejercicio12
{
    class Program
    {
        public static List<string> productos = new List<string>();
        public static List<double> precios = new List<double>();

        //Funcion que elimina productos.
        static void eliminar() 
        {
            int eliminarNum = -1;
            string eleccioneleminar = "y";
            while (eleccioneleminar == "y")
            {
                //Se muestra la lista 
                Console.WriteLine("\n*********************************************************");
                imprimirListas();
                Console.WriteLine("*********************************************************\n");
                Console.WriteLine("Escriba el indice del producto que quiera eliminar:");
                string eliminar = Console.ReadLine();
                //validacion de que no se ingrese letra no se menor a 0 ni mayor al numero de productos en la lista
                while (eliminarNum < 0)
                {
                    if (int.TryParse(eliminar, out eliminarNum) == false)
                    {
                        Console.WriteLine("[!] El indice a eliminar debe de ser un numero");
                        Console.WriteLine("Ingrese de nuevo el indice");
                        eliminar = Console.ReadLine();
                        eliminarNum = -1;
                    }
                    else if (eliminarNum < 0)
                    {
                        Console.WriteLine("[!] El indice debe ser positivo o igual 0");
                        Console.WriteLine("Ingrese de nuevo el indice");
                        eliminar = Console.ReadLine();
                        eliminarNum = -1;
                    }
                    else if (eliminarNum >= productos.Count)
                    {
                        Console.WriteLine("[!] El indice no existe el indice.");
                        Console.WriteLine("Ingrese de nuevo el indice"); 
                        eliminar = Console.ReadLine();
                        eliminarNum = -1;
                    }
                }
                //Si la opcion es valida se eliminan el producto y se pregunta si desea borrar o pasar a pagar o bien si ya no hay productos se sale de la funcion
                productos.RemoveAt(eliminarNum);
                precios.RemoveAt(eliminarNum);
                Console.WriteLine("[!] Producto borrado\n");
                if (productos.Count != 0)
                {
                    Console.WriteLine("Desea borrar otro producto? (y/n)");
                    eleccioneleminar = Console.ReadLine();
                    while (eleccioneleminar != "y" && eleccioneleminar != "n")
                    {
                        Console.WriteLine("Debe de teclear Y o N para seguir ingresando productos o para pasar a pagar");
                        eleccioneleminar = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("[!] Ya no quedan productos que borrar.");
                    eleccioneleminar = "n";
                }

            }
            Console.WriteLine();
        }
        //Esta funcion simplemente muestra ambas listas con cierto formato.
        static double imprimirListas()
        {
            double total = 0;
            Console.WriteLine("Indice\tProducto\t\t\tPrecio");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine("[{0}]\t{1}\t\t\t{2:C}", i ,productos[i],precios[i]);
                total += precios[i];
            }
            Console.WriteLine("Precio Total:\t\t{0:C}", total);
            return total;
        }
        static void Main(string[] args)
        {
            string producto="", precio = "", eleccion = "y";
            double precioNum = 0,total,DineroCliente=500;
            //Este programa comienza realizando el ingreso de almenos un producto.
            Console.WriteLine("Bienvenidoal BecarioMart");
            while (eleccion == "y")
            {
                precioNum = 0;
                Console.WriteLine("Ingrese el producto:");
                producto = Console.ReadLine();
                //Validacion para que no ingrese cadenas vacias.
                while (producto.Length == 0)
                {
                    Console.WriteLine("Debe Ingresar un nombre, al menos un caracter");
                    producto = Console.ReadLine();
                }
                Console.WriteLine("Ingrese el precio:");
                precio = Console.ReadLine();
                //Validaciones para no ingresar letra o numeros negativos
                while (precioNum <= 0)
                {
                    if (double.TryParse(precio, out precioNum) == false)
                    {
                        Console.WriteLine("ERROR: El precio debe de ser un numero. Con o sin punto decimal");
                        Console.WriteLine("Presiona cualquier tecla para salir.");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    if (precioNum <= 0)
                    {
                        Console.WriteLine("El precio debe ser positivo superior a 0");
                        precio = Console.ReadLine();
                    }
                }
                //Se agregan los productos y los precios y se pregunta si se quiere agregar otro producto o bien se pasa a pagar.
                productos.Add(producto);
                precios.Add(precioNum);
                Console.WriteLine(">> Desea ingresar otro producto? (y/n)");
                eleccion = Console.ReadLine();
                while (eleccion != "y" && eleccion != "n") 
                {
                    Console.WriteLine(">> Debe de teclear y o n para seguir ingresando productos o para pasar a pagar");
                    eleccion = Console.ReadLine();
                }
            }
            while (eleccion != "-1")
            {
                //Se muestran las listas y se pregunta por la operacion deseada
                Console.WriteLine("\n_________________________________________________________");
                total = imprimirListas();
                Console.WriteLine("_________________________________________________________\n");
                Console.WriteLine("Que desea hacer?\n 1)Comprar\t2)Dejar Productos");
                eleccion = Console.ReadLine();
                switch (eleccion)
                {
                    //En este caso se realiza la compra si se dispone del dinero (fijado en 500) de lo contrario lo obliga a eliminar productos
                    case "1":
                        if (DineroCliente < total)
                        {
                            Console.WriteLine("\n[!] No tiene suficiente dinero debe eliminar algun producto\n");
                            eliminar();
                        }
                        else
                        {
                                Console.WriteLine("\nGracias por su compra! :D");
                                Console.WriteLine("\nPresione una tecla para salir");
                                eleccion = "-1";
                        }
                        break;
                        //En este caso se manda a eliminar los productos al menos que no existan producto es ese caso se da el mensaje de que salga con la opcion de omprar.
                    case "2":
                        if (productos.Count > 0)
                        {
                            eliminar();
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Ya no quedan produtos para borrar. Seleccione comprar para salir :C");
                        }
                        break;
                    default:
                        Console.WriteLine("\n[!] Opcion invalida:\n");
                        break;
                }
            }
        }
    }
}
