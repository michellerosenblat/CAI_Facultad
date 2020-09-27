using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    public class PersonaInexistenteException : Exception
    {
        public PersonaInexistenteException(int codigo, string persona) : base("No existe el " + persona + " con código " + codigo) { }
           
    }
}
