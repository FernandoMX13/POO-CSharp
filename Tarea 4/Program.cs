/*
 * Programa que simula una consola de windows.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Tarea4
{
    class Program
    {
        //Lista que es utilizada para guardar los hitoricos de los comandos utilizados.
        public static List<string> comandos = new List<string>();
        //Esta funcion revisa el uso de las comillas dobles
        static string [] identificando(string comando)
        {
            string[] casoEspecial = comando.Split(" ");
            int n = 0;
            //hacemos un conteo de comillas debido a que estas deben de ser pares
            foreach (char c in comando)
            {
                if (c == '"') ++n;
            }
            //Si no es par esta mal escrito, en otro caso continua con su funcionamiento
            if (n % 2 == 0)
            {
                //realizamos la separacion.
                string[] temp = comando.Split("\"");
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = temp[i].Replace('"', ' ');
                    temp[i] = temp[i].Trim();
                }
                //Se consdera especial el caso de move
                if (String.Compare(casoEspecial[0], "move", StringComparison.OrdinalIgnoreCase) != 0)
                {   
                    return temp;
                }
                else
                {
                    if (n == 2)
                    {
                        //Este caso es para cuando se ingresa < move "C:\Mi carpeta\a.txt" C:\carpeta\a.txt>
                        if (temp[temp.Length - 1] != "")
                        {
                            return temp;
                        }
                        //Este caso es para cuando se ingresa < move C:\carpeta\a.txt "C:\Mi carpeta\a.txt">
                        else
                        {
                            string[] temp2 = temp[0].Split(" ");
                            List<string> li = new List<string>();
                            for (int i = 0; i < temp2.Length; i++)
                            {
                                li.Add(temp2[i]);
                            }
                            li.Add(temp[temp.Length-2]);
                            return li.ToArray();
                        }
                    }
                    //Este caso es para cuando se ingresa < move "C:\otra carpeta\a.txt" "C:\Mi carpeta\a.txt">
                    else if (n == 4)
                    {
                        List<string> li = new List<string>();
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] != "")
                                li.Add(temp[i]);
                        }
                        return li.ToArray();
                    }
                    else
                        return null;
                }
            }
            else
            {
                Console.WriteLine("Faltan comilas doble");
                return null;
            }
        }
        //Esta funcion muestra el historial de comando con cierto formato.
        static void imprimirComandos()
        {
            for (int i = 0; i < comandos.Count; i++)
            {
                Console.WriteLine("{0}:\t{1}", i, comandos[i]);
            }
        }
        //Funcion que es utlizada para mostrar el contenido de un directorio.
        static void mostrarContenidoDirectorio(DirectoryInfo directorio)
        {
            foreach (var dir in directorio.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }
            foreach (var file in directorio.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
        }

        static void Main(string[] args)
        {
            //Averiguamos donde esta la carpeta especial de Documentos de Windows
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string comando = null;
            int n = 0;
            while (comando != "exit")
            {
                //Imprimimos la direccion como en la terminal de windows y pedimos el comando a ejecutar.
                DirectoryInfo dInfo = new DirectoryInfo(rutaDocumentos);
                Console.Write("{0}>  ", dInfo.FullName);
                
                comando = Console.ReadLine();
                if (comando.Length==0)
                    comandos.Add(comando);
                //El comando y sus posibles argumentos son guardados en un arreglo para facilitar su manipulacion
                string[] comandat = comando.Split(' ');
                //Dir puede o no tener un argumento, en caso de que reciba mas de un argumento lo notifica.
                if (String.Compare("dir", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    if (comando.Contains("\""))
                        comandat = identificando(comando);
                    if (comandat != null)
                    {
                        if (comandat.Length > 2)
                            Console.WriteLine("Solo se acepta un directorio. Si trata de acceder a una carpeta con espacio en su nombre encierre el nombre entre comillas dobles");
                        else
                        {
                            //Este caso muestra el contenido del direcctorio actual
                            if (comandat.Length == 1)
                            {
                                mostrarContenidoDirectorio(dInfo);
                            }
                            //En este caso recibe una direccion absoluta del direcctorio a revisar. Se comprueba que exista,
                            //En caso de existir se muestra el contenido, en caso contrario se notifica que la carpeta no exite.
                            else if (comandat[1].Contains(":\\"))
                            {
                                DirectoryInfo comandDirinfo = new DirectoryInfo(comandat[1]);
                                if (comandDirinfo.Exists)
                                    mostrarContenidoDirectorio(comandDirinfo);
                                else
                                    Console.WriteLine("El directorio {0} no existe.", comandat[1]);
                            }
                            else
                            {
                                DirectoryInfo test = new DirectoryInfo(rutaDocumentos + "\\" + comandat[1]);
                                if (test.Exists)
                                    mostrarContenidoDirectorio(test);
                                else
                                    Console.WriteLine("El directorio {0} no existe en la ruta actual.", comandat[1]);
                            }
                        }
                    }
                }
                //cd necesita obligatoriamente de un argumento, sì no lo recibe lo notifica.
                else if (String.Compare("cd", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    if (comando.Contains("\""))
                        comandat = identificando(comando);
                    if (comandat != null)
                    {
                        if (comandat.Length != 2)
                            Console.WriteLine("El comando cd necesita un argumento.");
                        else
                        {
                            //En este caso, si se recibe ".." se hace alucion al direcctorio padre por lo tanto se cambia
                            //la ruta actual por la de su padre.
                            if (String.Compare("..", comandat[1], StringComparison.OrdinalIgnoreCase) == 0)
                                try
                                {
                                    rutaDocumentos = Convert.ToString(dInfo.Parent);
                                }
                                //Puede existir el error de que no se tenga permiso de ingresar al fichero.
                                catch (UnauthorizedAccessException)
                                {
                                    Console.WriteLine("Permiso denegado");
                                }
                            //cd puede recibir una ruta absoluta que contendra obligatoriamente la sucesion ":\" para reconocerla
                            //como tal, en ese caso se verifica que exista en caso contrario se notifica.
                            else if (comandat[1].Contains(":\\"))
                            {
                                DirectoryInfo test = new DirectoryInfo(comandat[1]);
                                if (test.Exists)
                                    try
                                    {
                                        rutaDocumentos = comandat[1];
                                    }
                                    //Puede existir el error de que no se tenga permiso de ingresar al fichero.
                                    catch (UnauthorizedAccessException)
                                    {
                                        Console.WriteLine("Permiso denegado");
                                    }
                                else
                                    Console.WriteLine("El directorio {0} no existe.", comandat[1]);
                            }
                            //cd tambien puede hacer alucion a una carpeta contenida en el direcctorio actual en este caso
                            //no se necesita de la ruta absoluta.
                            else
                            {
                                DirectoryInfo test = new DirectoryInfo(rutaDocumentos + "\\" + comandat[1]);
                                if (test.Exists)
                                    try
                                    {
                                        rutaDocumentos = Convert.ToString(test);
                                    }
                                    //Puede existir el error de que no se tenga permiso de ingresar al fichero.
                                    catch (UnauthorizedAccessException)
                                    {
                                        Console.WriteLine("Permiso denegado");
                                    }
                                else
                                    Console.WriteLine("El directorio {0} no existe en la ruta actual.", comandat[1]);
                            }
                        }
                    }
                }
                //Touch requiere necesariamente de un argumento en caso de no recibirlo lo notifica
                else if (String.Compare("touch", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    if (comando.Contains("\""))
                        comandat = identificando(comando);
                    if (comandat != null)
                    {
                        if (comandat.Length != 2)
                            Console.WriteLine("El comando touch requiere de un solo argumento. Si esta colocando una ruta con algun espacio encierre la ruta completa entre comillas dobles");
                        else
                        {
                            //El archivo a crear puede ser una ruta absoluta por ello se hace uso de la misma comprobacion
                            //antes vista
                            if (comandat[1].Contains(":\\"))
                            {
                                //Caso de que ya exista el archivo.
                                if (File.Exists(comandat[1]))
                                    Console.WriteLine("El archivo ya existe");
                                else
                                {
                                    try
                                    {
                                        //Caso de que no esxita e archivo.
                                        FileStream fs = File.Create(comandat[1]);
                                        fs.Close();
                                        Console.WriteLine("Archivo {0} Creado",comandat[1]);
                                    }
                                    //Puede existir el error de que no se encenutre la ruta especidficada
                                    catch (DirectoryNotFoundException)
                                    {
                                        Console.WriteLine("No se puede encontara la ruta especificada");
                                    }
                                    //Puede existir el error de que no se tenga permiso de ingresar al fichero.
                                    catch (UnauthorizedAccessException)
                                    {
                                        Console.WriteLine("Permiso denegado");
                                    }
                                }
                            }
                            else
                            {
                                //En esta seccion se crea en el fichero actual.
                                //Se revisa que exita.
                                if (File.Exists(rutaDocumentos + "\\" + comandat[1]))
                                    Console.WriteLine("El archivo ya existe");
                                else
                                {
                                    try
                                    {
                                        FileStream fs = File.Create(rutaDocumentos + "\\" + comandat[1]);
                                        fs.Close();
                                        Console.WriteLine("Archivo {0} Creado", comandat[1]);
                                    }
                                    catch (UnauthorizedAccessException)
                                    {
                                        Console.WriteLine("Permiso denegado");
                                    }
                                }
                            }
                        }
                    }
                }
                //La accion de move requiere de dos argumentos que seria la ruta absoluta, en caso de no recibirlos se notifica.
                else if (String.Compare("move", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    if (comando.Contains("\""))
                        comandat = identificando(comando);
                    foreach (string cad in comandat)
                    {
                        Console.WriteLine("<< "+ cad);
                    }
                    Environment.Exit(1);
                    if (comandat != null)
                    {
                        if (comandat.Length != 3)
                            Console.WriteLine("El comando touch necesita de dos argumentos.");
                        else
                        {
                            //Se valida que se recibieron rutas absolutas
                            if (!comandat[1].Contains(":\\") || !comandat[2].Contains(":\\"))
                                Console.WriteLine("No escribio la ruta completa del archivo");
                            else
                            {
                                //En caso de que sean rutas absolutas se verifica que sen direcciones accesibles y con permiso de escritura en ellos
                                Console.WriteLine(">> " + comandat[1]);
                                if (File.Exists(comandat[1]))
                                {
                                    try
                                    {
                                        File.Move(comandat[1], comandat[2]);
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Console.WriteLine("No se encontro la ruta especificada");
                                    }
                                    catch (UnauthorizedAccessException)
                                    {
                                        Console.WriteLine("Permiso denegado");
                                    }
                                    catch (IOException)
                                    {
                                        Console.WriteLine("El archvo ya existe");
                                    }
                                }
                                else
                                    Console.WriteLine("No exite el archivo.");
                            }
                        }
                    }
                }
                //Esta funcion mustra el historial de comandos.
                else if (String.Compare("history", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    imprimirComandos();
                }
                //Esta funcion limpia la pantalla.
                else if (String.Compare("cls", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.Clear();
                }
                //Cualquier otra cosa que se reciba muestra que no es un comando valido.
                else if (String.Compare("exit", comandat[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    Console.WriteLine("Sayonara :D");
                }
                //Cualquier otra cosa que se reciba muestra que no es un comando valido.
                else
                    Console.WriteLine("Comando no aceptado.");
            }
        }
    }
}
