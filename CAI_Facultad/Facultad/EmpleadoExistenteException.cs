using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException(Empleado empleado) : base("El empleado con legajo " + empleado.Legajo + " ya existe") { }
    }
}
