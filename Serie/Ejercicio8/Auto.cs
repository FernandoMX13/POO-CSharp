/*
Clase de Autos
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Auto
    {
        private string Marca;
        private string Modelo;
        private double Rendimiento;
        private int capacidadCombustible;
        private double KmRecorridos;
        private double estadoCombustible;
        public string marca 
        {
            get { return Marca; }
        }

        public string modelo
        {
            get { return Modelo; }
        }

        public double rendimiento
        {
            get { return Rendimiento; }
        }

        public int capaCom
        {
            get { return capacidadCombustible; }
        }
        public double KMRec
        {
            set { KmRecorridos = value; }
            get { return KmRecorridos; }
        }

        public double estaComb
        {
            set { estadoCombustible = value; }
            get { return estadoCombustible; }
        }
        //El construccto necesita de solo la marca o el modelo.
        public Auto(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Rendimiento = 13.5;
            capacidadCombustible = 40;
            KMRec = 0;
            estaComb = 0;
        }
        //Se sobrecarga la funcion pero ahora pidiando todos los datos.
        public Auto(string marca, string modelo, double rendimiento, int capaciCob, double km, double comb)
        {
            Marca = marca;
            Modelo = modelo;
            Rendimiento = rendimiento;
            capacidadCombustible = capaciCob;
            KmRecorridos = km;
            estaComb = comb;
        }
        //La recarga de combustible depende de la capacidad del tanque no se puede recargar mas combustible del que le cabe al tanque.
        public void recargarCombustible(int cant) 
        {
            if (estaComb + cant <= capacidadCombustible)
            {
                estaComb += cant;
                Console.WriteLine("Se han cargado {0} litros de combustible\nUsted tiene ahora {1} litros", cant, estaComb);
            }
            else
            {
                Console.WriteLine("No puede recargar {0} litros de combustibe debido a que rebasa la capacidad de combustible que es de {1} litros.", cant, capaCom);
                Console.WriteLine("Actualmente tiene {0} litros de combustible.",estaComb);
            }
        }
        //Viaje depende del rendimiento y la cantidad de combustible actual si la cantidad de combustible no alcanza para realizar el viaje
        //entonces este no se efectua pero si se puede se resta el combustible empleado y se le agregan kilometros al contados.
        public void viajar(double cant) 
        {
            if (estaComb * rendimiento > cant)
            {
                Console.WriteLine("Se realiza el viaje.");
                KMRec += cant;
                estaComb -= 1/(rendimiento/cant);
                Console.WriteLine("Ha recorrido en total {0:N2} Km.", KMRec);
                Console.WriteLine("Y gasto {0:N2} litros de combustible", 1 / (rendimiento / cant));
                Console.WriteLine("EL vehiculo tiene aun {0:N2} litros de combustible", estaComb);
            }
            else
                Console.WriteLine("No puede realizar el viaje, no tiene suficiente combustible para realizarlo");
        }
        //El reseteo del kilometraje permite poner este en 0
        public void reset()
        {
            Console.WriteLine("Acaba de resetear el contado de kilometros de {0:N2} km a 0 km", KMRec);
            KMRec = 0;
        }
        //Muestra informacion relacionada con el auto.
        public string info()
        {
            return string.Format("Informacion del vehiculo:\n Marca:\t{0}\n Modelo:\t{1}\n Rendimientos:\t{2} km/l\n Capacidad de combustible:\t{3} litros\n Kilometros recorridos:\t{4:N2} Km\n Cantidad de conbustible actual:\t{5:N2} litros\n", marca, modelo, rendimiento, capaCom, KMRec, estaComb);
        }
    }
}
