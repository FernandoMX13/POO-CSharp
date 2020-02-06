using System;

namespace persona
{
    class persona
    {

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            persona p = obj as persona;
            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }
    }
}
