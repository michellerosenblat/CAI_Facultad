using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    abstract class Persona
    {
        string nombre;
        string apellido;
        DateTime fechaNac;

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
                return new DateTime(DateTime.Now.Subtract(fechaNac).Ticks).Year - 1;
            }
        }

        public abstract string GetCredencial();
        public string GetNombreCompleto()
        {
            return nombre + apellido;
        }
    }
}
