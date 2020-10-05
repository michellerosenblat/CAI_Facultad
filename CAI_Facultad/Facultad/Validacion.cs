using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    public static class Validacion
    {

        public static string PedirString(string mensaje)
        {
            string dato = "";
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                dato = Console.ReadLine();
            }
            while (dato == "");
            return dato;
        }
        public static DateTime PedirFecha(string mensaje)
        {
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
            }
            while (!DateTime.TryParse(Console.ReadLine(), out fecha));
            return fecha;
        }
        public static int PedirNumero(string mensaje)
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
            }
            while ((!int.TryParse(Console.ReadLine(), out numero)));
            return numero;
        }
        public static string PedirStringOEnter(string mensaje, string valorDefault)
        {
            Console.WriteLine("Ingrese " + mensaje + " o enter si no quiere modificar");
            string dato = Console.ReadLine();
            if (dato == "")
            {
                return valorDefault;
            }
            else
            {
                return dato;
            }

        }
        public static DateTime PedirFechaOEnter(string mensaje, DateTime valorDefault)
        {
            DateTime fecha;
            string fechaString;
            do {
                Console.WriteLine("Ingrese " + mensaje + " o enter si no quiere modificar");
                fechaString = Console.ReadLine();
                if (fechaString == "")
                {
                    return valorDefault;
                }
            }
            while (!DateTime.TryParse(fechaString, out fecha));
            return fecha;

        }
    }
}
