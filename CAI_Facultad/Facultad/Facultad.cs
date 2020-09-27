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
        public void EliminarAlumno (int codigoAlumno) {
            try {
                alumnos.Find(a => a.Codigo == codigoAlumno);
            }
            catch (Exception)
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
            catch (Exception)
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


        public string ListarAlumnoEspecifico(int codigoAlumno)
        {
            Alumno alumno = alumnos.Find(a => a.Codigo == codigoAlumno);
            if (alumno is null)
            {
                throw new PersonaInexistenteException(codigoAlumno, "alumno");
            }
            else
            {
                return alumno.ToString();
            }

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
    }
}
