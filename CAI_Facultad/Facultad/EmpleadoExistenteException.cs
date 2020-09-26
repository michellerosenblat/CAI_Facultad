using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException(Empleado empleado) : base("El empleado con legajo " + empleado.Legajo + " ya existe") { };
    }
}
