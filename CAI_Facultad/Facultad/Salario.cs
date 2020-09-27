using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibrary
{
    public class Salario
    {
        double bruto;
        string codigoTransferencia;
        double porcentajeDescuento;
        DateTime fecha;

        public double Bruto
        {
            get
            {
                return bruto;
            }
            set
            {
                bruto = value;
            }
        }
        public string CodigoTransferencia
        {
            get
            {
                return codigoTransferencia;
            }
            set
            {
                codigoTransferencia = value;
            }
        }
        public double PorcentajeDescuento
        {
            get
            {
                return porcentajeDescuento;
            }
            set
            {
                porcentajeDescuento = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public double GetSalarioNeto ()
        {
            return bruto * (100-porcentajeDescuento)/100;
        }

        public double Deducciones ()
        {
            return bruto - GetSalarioNeto();
        }

    }
}
