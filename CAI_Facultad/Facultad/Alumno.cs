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
        public string Credencial
        {
          get
            {

            }
            set
            {

            }
        }
        public override string ToString()
        {
            return GetCredencial() ;
        }

    }
}
