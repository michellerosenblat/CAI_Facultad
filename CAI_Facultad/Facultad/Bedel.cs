using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Bedel : Empleado
    {
        string apodo;
        public Bedel (string nombre, string apodo, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo) :
           base(nombre, apellido, fechaNac, fechaIngreso, legajo)
        {
            this.apodo = apodo;
        }
        public string Apodo
        {
            get
            {
                return apodo;
            }
            set
            {
                apodo = value;
            }
        }
        public override string GetNombreCompleto()
        {
            return "Bedel " + apodo;
        }
    }
}
