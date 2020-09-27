using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    public class AlumnoExistenteException : Exception
    {
        public AlumnoExistenteException(Alumno alumno) : base("El alumno con codigo " + alumno.Codigo + " ya existe") { }
    }
}
