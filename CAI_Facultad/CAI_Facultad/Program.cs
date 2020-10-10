using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FacultadLibrary;

namespace CAI_Facultad
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu;
            int codAlumno;
            string nombre;
            string apellido;
            string apodo;
            int codEmpleado;
            int tipoEmpleado;
            DateTime fechaNacimiento;
            DateTime fechaIngreso;
            Facultad facultad = new Facultad("UBA");
            
            while (true) {
                DesplegarOpcionesMenu();
                opcionMenu = Validacion.PedirNumero("la opción de menú que desee");
                switch (opcionMenu)
            {
                case 1:
                        //Agregar alumno
                    nombre = Validacion.PedirString("nombre del alumno");
                    apellido = Validacion.PedirString("apellido del alumno");
                    fechaNacimiento = Validacion.PedirFecha("fecha de nacimiento");
                    try {
                        facultad.AgregarAlumno(nombre, apellido, fechaNacimiento);
                    }
                    catch (AlumnoExistenteException e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                    case 2:
                        //modificar alumno
                        ListarAlumnosDe(facultad);
                        codAlumno = Validacion.PedirNumero("el código de alumno a modificar");
                        try
                        {
                           Console.WriteLine("Elegiste " + facultad.BuscarAlumno(codAlumno).ToString());
                            nombre = Validacion.PedirString("nombre del alumno");
                            apellido = Validacion.PedirString("apellido del alumno");
                            fechaNacimiento = Validacion.PedirFecha("fecha de nacimiento");
                            Alumno alumnoAModificar = new Alumno(nombre, apellido, fechaNacimiento, codAlumno);
                            facultad.ModificarAlumno(alumnoAModificar);
                            Console.WriteLine("Alumno modificado exitosamente");
                        }
                        catch (PersonaInexistenteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        //eliminar alumno
                        facultad.AgregarAlumno("Michelle", "Rosenblat", new DateTime(1998, 03, 04));
                        facultad.AgregarAlumno("Juan", "Perez", new DateTime(1998, 04, 04));
                        ListarAlumnosDe(facultad);
                        codAlumno = Validacion.PedirNumero("el código de alumno a eliminar");
                        try
                        {
                            facultad.EliminarAlumno(codAlumno);
                            Console.WriteLine("Alumno eliminado exitosamente");
                        }
                        catch (PersonaInexistenteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        //buscar alumno especifico
                            codAlumno = Validacion.PedirNumero("el código de alumno a buscar");
                        try {
                            Console.WriteLine(facultad.BuscarAlumno(codAlumno));
                        }
                        catch (PersonaInexistenteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        //listar todos los alumnos
                        ListarAlumnosDe(facultad);
                        break;
                    case 6:
                        //agregar empleado
                        //esto se puede mejorar? para no tener q asignar todo el tiempo en estas variables.
                        nombre = Validacion.PedirString("nombre del empleado");
                        apellido = Validacion.PedirString("apellido del empleado");
                        fechaNacimiento = Validacion.PedirFecha("fecha de nacimiento del empleado");
                        fechaIngreso = Validacion.PedirFecha("fecha de ingreso del empleado");
                        tipoEmpleado = Validacion.PedirNumero("1 para Docente, 2 para Directivo, 3 para Bedel");
                        switch (tipoEmpleado)
                        {
                            case 1:
                                facultad.AgregarEmpleado(nombre, apellido, fechaNacimiento, fechaIngreso, tipoEmpleado);
                                break;
                            case 2:
                                facultad.AgregarEmpleado(nombre, apellido, fechaNacimiento, fechaIngreso, tipoEmpleado);
                                break;
                            case 3:
                                apodo = Validacion.PedirString("apodo del bedel");
                                facultad.AgregarEmpleado(nombre, apodo, apellido, fechaNacimiento, fechaIngreso, tipoEmpleado);
                                break;
                        }
                        break;
                    case 7:
                        //Modificar empleado
                        Docente michu = new Docente("Michelle", "Rosen", new DateTime(1998, 04, 03), new DateTime(2020, 10, 05), facultad.UltimoLegajoEmpleado()+1);
                        facultad.AgregarEmpleado(michu);
                        ListarEmpleadosDe(facultad);
                        codEmpleado = Validacion.PedirNumero("el código de empleado a modificar");
                        try
                        {
                            Empleado empleadoAModificar = facultad.BuscarEmpleado(codEmpleado);
                            Console.WriteLine("Elegiste " + empleadoAModificar.GetCredencial());
                            switch (empleadoAModificar)
                            {
                                case Docente docente:
                                    ModificarEmpleado(out nombre, out apellido, out fechaNacimiento, out fechaIngreso, empleadoAModificar);
                                    Docente docenteAModificar = new Docente(nombre, apellido, fechaNacimiento, fechaIngreso, codEmpleado);
                                    facultad.ModificarEmpleado(docenteAModificar);
                                    Console.WriteLine(docenteAModificar.ToString());
                                    break;
                                case Directivo directivo:
                                    ModificarEmpleado(out nombre, out apellido, out fechaNacimiento, out fechaIngreso, empleadoAModificar);
                                    Directivo directivoAModificar = new Directivo(nombre, apellido, fechaNacimiento, fechaIngreso, codEmpleado);
                                    facultad.ModificarEmpleado(directivoAModificar);
                                    Console.WriteLine(directivoAModificar.ToString());                          
                                    break;
                                case Bedel bedel:
                                    ModificarEmpleado(out nombre, out apellido, out fechaNacimiento, out fechaIngreso, empleadoAModificar);
                                    Console.WriteLine(bedel.Apodo);
                                    apodo = Validacion.PedirStringOEnter("apodo", bedel.Apodo);
                                    Bedel bedelAModificar = new Bedel(nombre, apellido, apodo, fechaNacimiento, fechaIngreso, codEmpleado);
                                    facultad.ModificarEmpleado(bedelAModificar);
                                    Console.WriteLine(bedelAModificar.ToString());
                                    break;
                            }

                        }
                        catch (PersonaInexistenteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 8:
                        ListarEmpleadosDe(facultad);
                        codEmpleado = Validacion.PedirNumero("el código de empleado a eliminar");
                        try
                        {
                            Empleado empleadoAEliminar = facultad.BuscarEmpleado(codEmpleado);
                            Console.WriteLine("Elegiste " + empleadoAEliminar.GetCredencial());
                            facultad.EliminarEmpleado(codEmpleado);
                            Console.WriteLine("Se ha eliminado exitosamente el empleado con codigo " + codEmpleado);
                        }
                        catch (PersonaInexistenteException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                           
                        break;

                                case 10:
                        ListarEmpleadosDe(facultad);
                        break;

                }
            }



        }

        private static void ModificarEmpleado(out string nombre, out string apellido, out DateTime fechaNacimiento, out DateTime fechaIngreso, Empleado empleadoAModificar)
        {
            Console.WriteLine(empleadoAModificar.Nombre);
            nombre = Validacion.PedirStringOEnter("nombre", empleadoAModificar.Nombre);
            Console.WriteLine(empleadoAModificar.Apellido);
            apellido = Validacion.PedirStringOEnter("apellido", empleadoAModificar.Apellido);
            Console.WriteLine(empleadoAModificar.FechaIngreso.ToShortDateString());
            fechaIngreso = Validacion.PedirFechaOEnter("fecha ingreso", empleadoAModificar.FechaIngreso);
            Console.WriteLine(empleadoAModificar.FechaNacimiento.ToShortDateString());
            fechaNacimiento = Validacion.PedirFechaOEnter("fecha nacimiento", empleadoAModificar.FechaNacimiento);
        }

        private static void ListarAlumnosDe(Facultad facultad)
        {
            List<Alumno> alumnos = facultad.ListarTodosLosAlumnos();
            if (!alumnos.Any ())
            {
                Console.WriteLine("No hay alumnos cargados"); 
            }
            else { 
            foreach (Alumno a in alumnos)
            {
                Console.WriteLine(a.ToString());
            }
            }

        }

        private static void ListarEmpleadosDe(Facultad facultad)
        {
            List<Empleado> empleados = facultad.ListarTodosLosEmpleados();
            if (!empleados.Any())
            {
                Console.WriteLine("No hay empleados cargados");
            }
            else
            {
                foreach (Empleado e in empleados)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }

        private static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Opcion 1: Agregar alumno");
            Console.WriteLine("Opcion 2: Modificar alumno");
            Console.WriteLine("Opcion 3: Eliminar alumno");
            Console.WriteLine("Opcion 4: Buscar alumno específico");
            Console.WriteLine("Opcion 5: Listar todos los alumnos");
            Console.WriteLine("Opcion 6: Agregar empleado");
            Console.WriteLine("Opcion 7: Modificar empleado");
            Console.WriteLine("Opcion 8: Eliminar empleado");
            Console.WriteLine("Opcion 9: Buscar empleado específico");
            Console.WriteLine("Opcion 10: Listar todos los empleados");
        }
        

    }
}
