/*
Clase de numero complejo el cual posee los atributos de parte real y parte imaginaria.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class NumeroComplejo
    {
        private int parteReal;
        private int parteImaginaria;

        public int pr
        {
            get { return parteReal; }
            set { parteReal = value; }
        }

        public int pi
        {
            get { return parteImaginaria; }
            set { parteImaginaria = value; }
        }
        //Constructor que pide la parte real y la imaginaria
        public NumeroComplejo(int Real, int Imag) 
        {
            pr = Real;
            pi = Imag;
        }
        //Impresion de los numeros estos se hacen de manera polar.
        public string Imprimir()
        {
            //Si la parte real es cero no se muestra. Almenos que la parte imaginaria sea creo entonces si se muestra.
            //Si la parte imaginaria solo es 1 o -1 se imprime solo la i o -1.
            //Al no exisitir la parte real el signo de + no se muestra
            if (parteReal == 0)
            {
                if (parteImaginaria == 0)
                    return string.Format("{0}",parteReal);
                else if(parteImaginaria == 1)
                    return string.Format("i");
                else if(parteImaginaria == -1)
                    return string.Format("-i");
                else
                    return string.Format("{0}i",parteImaginaria);
            }
            //En esta parte se imprime el numero imaginario incluyedo el signo +
            else 
            {
                if (parteImaginaria == 0)
                    return string.Format("{0}", parteReal);
                else if (parteImaginaria > 0)
                {
                    if (parteImaginaria == 1)
                        return string.Format("{0}+i", parteReal);
                    else
                        return string.Format("{0}+{1}i", parteReal, parteImaginaria);
                }
                else
                {
                    if (parteImaginaria == -1)
                        return string.Format("{0}-i",parteReal);
                    else
                        return string.Format("{0}{1}i", parteReal, parteImaginaria);
                }
            }
        }
    }
}
