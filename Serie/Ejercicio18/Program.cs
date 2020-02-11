/*
Este programa es un repensamiento del ejercicio tres ya que obtiene de un archivo las cadenas y coloca una f antes de cada vocal.
y ademas de mostrar el resultado en pantalla lo imprime tambien en un  archivo.
*/

using System;
using System.IO;

namespace Ejercicio18.txt
{
    class Program
    {
        static void AgregarF(string cad, bool flag)
        {
            string cadlow = cad.ToLower();
            //Busca la carpeta desktop
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Se sigue la logica del progrma tres solo con la diferencia de que se escribe tabien en un archivo
            //Se usa flag para saber si es la primera escritura, si es asi escribe en el principio borrando todo el anterior contenido,
            for (int i = 0; i < cad.Length; i++)
            {
                if (cadlow[i] == 'a' || cadlow[i] == 'e' || cadlow[i] == 'i' || cadlow[i] == 'o' || cadlow[i] == 'u')
                {
                    Console.Write("f{0}", cad[i]);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "LyricsF.txt"), flag))
                    {
                        outputFile.Write("f{0}",cad[i]);
                    }
                }
                else
                {
                    Console.Write("{0}", cad[i]);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "LyricsF.txt"), flag))
                    {
                        outputFile.Write("{0}",cad[i]);
                    }
                }
                flag = true;
            }
            Console.Write("\n");
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "LyricsF.txt"), flag))
            {
                outputFile.Write("\n");
            }

        }

        static void Main(string[] args)
        {
            try
            {
                //Consigue la ruta hacia la careta especial Desktop
                string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //Crea un objeto de lectura de ese documento.
                //[!] Para su correcto funcionamiento se requiere que el archivo Lyrics se en cuentre en el escritorio.
                StreamReader file = new StreamReader(Path.Combine(sourcePath, "Lyrics.txt"));
                string line;
                bool flag = false;
                //Lee linea a linea y lo manda ala funcion que escribe antes F
                while ((line = file.ReadLine()) != null)
                {
                    AgregarF(line, flag);
                    flag = true;
                }
                Console.WriteLine("\n[!] Puede revisar el archivo \"Lyrics.txt\" en el escritorio para ver el resultado.");
                Console.WriteLine("\nPresione una tecla para salir");
                Console.ReadKey();
                file.Close();
            }
            //Una escepcion que puede existir es que no exista el archivo por ello se captura.
            catch (System.IO.FileNotFoundException NoFile)
            {
                Console.WriteLine(NoFile.Message);
                Console.WriteLine("El archivo \"Lyrics.txt\" se debe de encontrar en el escritorio");
                Console.WriteLine("\nPresione una tecla para salir");
                Console.ReadKey();
            }
        }
    }
}