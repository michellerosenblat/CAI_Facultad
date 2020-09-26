using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Facultad
    {
        List<Alumno> alumnos;
        int cantidadSedes;
        List<Empleado> empleados;
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
        public void AgregarAlumno (Alumno alumno)
        {
            if (!alumnos.Any (a => a.Equals(alumno)))
            {
                alumnos.Add(alumno);
            }
            else
            {
                throw new AlumnoExistenteException(alumno);
            }

        }
        public void AgregarEmpleado (Empleado empleado)
        {
            if (!empleados.Any(e => e.Equals(empleado)))
            {
                empleados.Add(empleado);
            }
            else
            {
                throw new EmpleadoExistenteException(empleado);
            }
        }
        public void EliminarAlumno (int codigoAlumno) {
            try {
                alumnos.Find(a => a.Codigo == codigoAlumno);
            }
            catch (Exception e)
            { 
                throw new PersonaInexistenteException(codigoAlumno, "alumno");
            }
        }
        public void EliminarEmpleado(int legajo)
        {
            try
            {
                empleados.Find(e => e.Legajo == legajo);
            }
            catch (Exception e)
            {
                throw new PersonaInexistenteException(legajo, "empleado");
            }
        }
        public void ModificarAlumno (Alumno alumno)
        {
            EncontrarAlumno(alumno);
        }

        public Alumno EncontrarAlumno (Alumno alumno)
        {
            return alumnos.Find(a => a.Codigo == alumno.Codigo);
        }

    }
}
