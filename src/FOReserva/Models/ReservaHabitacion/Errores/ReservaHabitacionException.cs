using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FOReserva.Models.ReservaHabitacion.Errores
{
    public class ReservaHabitacionException : Exception
    {
        public ReservaHabitacionException(String mensaje, Exception excepcionInterna) : base(mensaje, excepcionInterna) {

        }
    }
}