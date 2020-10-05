using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    public class NoHaySueldoException : Exception
    {
        public NoHaySueldoException () : base ("No hay ningun sueldo cargado") { }
    }
}
