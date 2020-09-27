using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacultadLibrary
{
    public class Empleado : Persona
    {
        protected DateTime fechaIngreso;
        protected int legajo;
        protected List<Salario> salarios;

        public Empleado(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo) :
            base(nombre, apellido, fechaNac)
        {
            this.fechaIngreso = fechaIngreso;
            this.legajo = legajo;
            salarios = new List<Salario> { };
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
                return salarios.OrderByDescending(s => s.Fecha).First();
                //Salarios.find(s -> s.fecha = Salarios.max(salario -> salario.fecha()))
            }
        }
        public void AgregarSalario(Salario salarioAgregar)
        {
            salarios.Add(salarioAgregar);   
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public override bool Equals(object obj)
        {
            return (obj != null && obj is Empleado && this.legajo == ((Empleado)obj).legajo);
        }
    }
}
