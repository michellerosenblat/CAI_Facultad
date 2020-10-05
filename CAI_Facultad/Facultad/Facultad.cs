using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    public class Facultad
    {
        List<Alumno> alumnos;
        int cantidadSedes;
        List<Empleado> empleados;
        string nombre;

        public Facultad (string nombre)
        {
            this.nombre = nombre;
            alumnos = new List<Alumno>();
            empleados = new List<Empleado>();
        }
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
        public void AgregarAlumno (string nombre, string apellido, DateTime fechaNac)
        {
            Alumno alumno = new Alumno(nombre, apellido, fechaNac, UltimoCodigoAlumno()+1 );
            AgregarAlumno(alumno);
        }
        public void AgregarAlumno(Alumno alumno)
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
        public void AgregarEmpleado (string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int tipoEmpleado)
        {
            switch (tipoEmpleado)
            {
                case 1:
                    Docente docente = new Docente(nombre, apellido, fechaNac, fechaIngreso, UltimoLegajoEmpleado() + 1);
                    AgregarEmpleado(docente);
                    break;
                case 2: 
                    Directivo directivo = new Directivo (nombre, apellido, fechaNac, fechaIngreso, UltimoLegajoEmpleado() + 1);
                    AgregarEmpleado(directivo);
                    break;
            }
        }
        public void AgregarEmpleado (string nombre, string apodo, string apellido, DateTime fechaNac, DateTime fechaIngreso, int tipoEmpleado)
        {
            Bedel bedel = new Bedel(nombre, apodo, apellido, fechaNac, fechaIngreso, UltimoLegajoEmpleado()+1);
            AgregarEmpleado(bedel);
        }
        public void EliminarAlumno (int codigoAlumno) {
            Alumno alumno = BuscarAlumno(codigoAlumno);
            alumnos.Remove(alumno);
        }
        public void EliminarEmpleado(int legajo)
        {
            try
            {
                empleados.Find(e => e.Legajo == legajo);
            }
            catch (Exception)
            {
                throw new PersonaInexistenteException(legajo, "empleado");
            }
        }

        public void ModificarAlumno (Alumno alumnoAModificar)
        {
            Alumno alumno = BuscarAlumno(alumnoAModificar.Codigo);
            alumno.Nombre = alumnoAModificar.Nombre;
            alumno.Apellido = alumnoAModificar.Apellido;
            alumno.FechaNacimiento = alumnoAModificar.FechaNacimiento;
        }
        public void ModificarEmpleado (Empleado empleadoAModificar)
        {
            Empleado empleado = BuscarEmpleado(empleadoAModificar.Legajo);
            empleado.Nombre = empleadoAModificar.Nombre;
            empleado.Apellido = empleadoAModificar.Apellido;
            empleado.FechaIngreso = empleadoAModificar.FechaIngreso;
            empleado.FechaNacimiento = empleadoAModificar.FechaNacimiento;
        }

        public Alumno BuscarAlumno (int codigoAlumno)
        {
           Alumno alumno = alumnos.Find(a => a.Codigo == codigoAlumno);
            if (alumno is null)
            {
                throw new PersonaInexistenteException(codigoAlumno, "alumno");
            }
            else
            return alumno;
        }

        public Empleado BuscarEmpleado (int legajoEmpleado)
        {
            Empleado empleado = empleados.Find(e => e.Legajo == legajoEmpleado);
            if (empleado is null)
            {
                throw new PersonaInexistenteException(legajoEmpleado, "empleado");
            }
            else
                return empleado;
        }

        public List <Alumno> ListarTodosLosAlumnos()
        {
            return alumnos;
        }
        public List<Empleado> ListarTodosLosEmpleados()
        {
            return empleados;
        }

        public int UltimoCodigoAlumno ()
        {
            if (alumnos.Any())
            {
                return alumnos.Max(a => a.Codigo);
            }
            else
                return 0;
        }
        public int UltimoLegajoEmpleado()
        {
            if (empleados.Any())
            {
                return empleados.Max(e => e.Legajo);
            }
            else
                return 0;
        }
    }
}
