using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Facultad
    {
        //List<Alumno> alumnos;
        int cantidadSedes;
        //List<Empleado> empleados;
        string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int CantidadSedes
        {
            get
            {
                return cantidadSedes;
            }
            set
            {
                this.cantidadSedes = value;
            }
        }
       /* public void AgregarAlumno (Alumno alumno)
        {

        }
        public void AgregarEmpleado (Empleado empleado)
        {
            empleados.Add(empleado);
        }
        public void EliminarAlumno (int codigoAlumno ) { }*/
    }
}
