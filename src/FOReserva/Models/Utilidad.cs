using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FOReserva.Models
{
    public class Utilidad
    {
        private static string origen = "DS1617A";
        private static string log = "Sistema Reserva";

        public static void RegistrarLog(Exception exception) {

            if (!EventLog.SourceExists(origen)) { 
                EventLog.CreateEventSource(origen, log);

                EventLog.WriteEntry(origen, exception.StackTrace);
            }
            throw exception;
        }

        public static EventLog[] ObtenerLogs(Exception exception)
        {
            return EventLog.GetEventLogs();
        }

    }
}