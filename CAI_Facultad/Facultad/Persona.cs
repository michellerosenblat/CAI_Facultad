using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    abstract public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNac;

        public Persona (string nombre, string apellido, DateTime fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fecha;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return ManejoFechas.DiferenciaFechas(fechaNac);
            }
        }

        public abstract string GetCredencial();
        public virtual string GetNombreCompleto()
        {
            return apellido +"," + nombre;
        }
    }
}
