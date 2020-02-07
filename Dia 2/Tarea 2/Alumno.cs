using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Alumno
    {
        private int cal_proyecto;
        private int cant_Tareas;
        private int participaciones;
        private string nombre;

        public Alumno(string nom, int proy, int tar, int part)
        {
            Nombre = nom;
            Proyecto = proy;
            Tareas = tar;
            Participaciones = part;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Proyecto
        {
            get { return cal_proyecto; }
            set 
            {
                if (value > 10)
                    cal_proyecto = 10;
                else if (value < 0)
                    cal_proyecto = 0;
                else
                    cal_proyecto = value;
            }
        }

        public int Tareas
        {
            get { return cant_Tareas; }
            set {
                if (value > 5)
                    cant_Tareas = 5;
                else if (value < 0)
                    cant_Tareas = 0;
                else
                    cant_Tareas = value;
            }
        }

        public int Participaciones
        {
            get { return participaciones; }
            set { participaciones = value; }
        }

        public override string ToString()
        {
            return string.Format("Alumno:\t{0}\n\tCalificacion proyecto:\t{1}\n\tTareas entregadas:\t {2}\n\tParticipaciones:\t{3}", Nombre,cal_proyecto,cant_Tareas,participaciones);
        }
    }
}
