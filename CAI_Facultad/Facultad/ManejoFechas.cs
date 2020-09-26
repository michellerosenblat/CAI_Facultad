using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    static class ManejoFechas
    {
        public static int DiferenciaFechas (DateTime fechaarestar)
        {
            return new DateTime(DateTime.Now.Subtract(fechaarestar).Ticks).Year - 1;
        }
    }
}
