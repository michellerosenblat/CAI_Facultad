using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    class Empleado : Persona
    {
        DateTime fechaIngreso;
        int legajo;
        List<Salario> salarios;

        public Empleado(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo) :
            base(nombre, apellido, fechaNac)
        {
            this.fechaIngreso = fechaIngreso;
            this.legajo = legajo;
        }
        public override string GetCredencial()
        {
            return legajo + " " + GetNombreCompleto() + " salario " + UltimoSalario;
        }

        public int Antiguedad
        {
            get
            {
                return ManejoFechas.DiferenciaFechas(fechaIngreso);
            }
        }
        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }
            set
            {
                fechaIngreso = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return FechaNacimiento;
            }
            set
            {
                FechaNacimiento = value;
            }
        }
        public int Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }
        public List<Salario> Salarios {
        get {
                return salarios;
            }
        }
        public Salario UltimoSalario
        {
            get
            {
                salarios.Last<Salario>;
            }
        }
    }
}
