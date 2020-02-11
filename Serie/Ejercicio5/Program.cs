/*
Agenda que guarda los contactos en un diccionario.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string eleccion = "0", name , phone;
            bool isNumeric;
            Dictionary<string, string> Agenda = new Dictionary<string, string>();
            //menu
            Console.WriteLine("Bienvenido a la agenda.\n");
            while (eleccion != "4")
            {
                Console.WriteLine("Escoja un opcion");
                Console.WriteLine("1) Agregar Contacto");
                Console.WriteLine("2) Eliminar Contacto");
                Console.WriteLine("3) Mostrar contacto");
                Console.WriteLine("4) Salir");
                Console.WriteLine("Escriba el numero de su eleccion");
                eleccion = Console.ReadLine();
                switch (eleccion)
                {
                    //En este caso se agrega los usuario al diccionario. Se realiza la validacion de ingresar al menos un caracter
                    //Por expresiones regulares se valida que se ingrese un numero de diez digitos.
                    case "1":
                        Console.WriteLine("\nEscogio agregar contacto:");
                        Console.WriteLine("Ingrese el nombre del contacto");
                        name = Console.ReadLine();
                        while (name.Length == 0 || Agenda.ContainsKey(name)) 
                        {
                            if (name.Length == 0)
                            {
                                Console.WriteLine("Debe ingresar almenos un caracter como nombre de contacto");
                                name = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("El contacto ya existe ingrese otro:");
                                name = Console.ReadLine();
                            }
                        }
                        Console.WriteLine("Ingrese el numero del contacto");
                        phone = Console.ReadLine();
                        while (Regex.IsMatch(phone, "^[0-9]{10}$") == false)
                        {
                            Console.WriteLine("El numero telefonico es invalido debe de contener solo numeros y tener una longitud de 10 digitos");
                            phone = Console.ReadLine();
                        }
                        Console.WriteLine("\nEl contacto {0} con numero: {1} ha sido guardado exitosamente.\n",name,phone);
                        Agenda.Add(name,phone);
                        break;
                    //En este caso se realiza el borrado de un contacto, se valida que se ingrese al menos un caracter y que este exista para
                    //borrarlo en otro caso no procede.
                    case "2":
                        Console.WriteLine("\nEscogio eliminar contacto:");
                        Console.WriteLine("Ingrese el nombre del contacto a eliminar");
                        name = Console.ReadLine();
                        while (name.Length == 0)
                        {
                            Console.WriteLine("Debe ingresar el nombre del contacto a eliminar");
                            name = Console.ReadLine();
                        }
                        if (Agenda.ContainsKey(name))
                        {
                            Agenda.Remove(name);
                            Console.WriteLine("\nContacto eliminado\n");
                        }
                        else
                        {
                            Console.WriteLine("\nEl contacto no existe\n");
                        }
                        break;
                    //En este caso solo se hace la muestra de un usurio, se valida que se ingrese algun caracter y 
                    //si existe el usuarioo se muestra
                    case "3":
                        Console.WriteLine("\nEscogio mostrar contacto:");
                        Console.WriteLine("Ingrese el nombre del contacto a mostrar:");
                        name = Console.ReadLine();
                        while (name.Length == 0)
                        {
                            Console.WriteLine("Debe ingresar el nombre del contacto a revisar");
                            name = Console.ReadLine();
                        }
                        if (Agenda.ContainsKey(name))
                        {
                            Console.WriteLine("\nNombre:\t{0}\nTelefono:\t{1}\n",name,Agenda[name]);
                        }
                        else
                        {
                            Console.WriteLine("\nEl contacto no existe\n");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Adios ;D");
                        break;
                    default:
                        Console.WriteLine("\nOpcion invalida:\n");
                        break;
                }


            }

        }
    }
}
