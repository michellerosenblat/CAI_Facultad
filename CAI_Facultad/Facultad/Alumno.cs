using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Alumno : Persona
    {
        int codigo;
        public override string GetCredencial()
        {
            return "Codigo " + codigo + GetCredencial();
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
        public 

    }
}
