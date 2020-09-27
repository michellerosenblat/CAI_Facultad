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
            Facultad facultad = new Facultad("UBA");
            while (true) {
                opcionMenu=0;
                DesplegarOpcionesMenu();
                opcionMenu = Validacion.PedirNumero("la opción de menú que desee");
                switch (opcionMenu)
            {
                case 1:
                        //Agregar alumno
                    string nombre;
                    string apellido;
                    DateTime fechaNacimiento;
                    nombre = Validacion.PedirString("nombre del alumno");
                    apellido = Validacion.PedirString("nombre del alumno");
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
                    case 3:
                    
                    //eliminar alumno
                    case 4:
                        //buscar alumno especifico
                        int codAlumno;

                            codAlumno = Validacion.PedirNumero("el código de alumno a buscar");
                        try {
                            Console.WriteLine(facultad.ListarAlumnoEspecifico(codAlumno));
                        }
                        catch (PersonaInexistenteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                           
                      
                        
                        break;

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
