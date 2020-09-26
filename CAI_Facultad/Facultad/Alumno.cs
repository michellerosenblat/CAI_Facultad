using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Alumno : Persona
    {
        int codigo;

        public Alumno (string nombre, string apellido, DateTime fechaNac, int codigo ) : base (nombre, apellido, fechaNac) {
            this.codigo = codigo;
        }
        public override string GetCredencial()
        {
            return "Codigo " + codigo + " " + GetCredencial();
        }
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public override string ToString()
        {
            return GetCredencial() ;
        }
        public override bool Equals(object obj)
        {
            return (obj != null && obj is Alumno && this.codigo == ((Alumno)obj).codigo);
        }

    }
}
