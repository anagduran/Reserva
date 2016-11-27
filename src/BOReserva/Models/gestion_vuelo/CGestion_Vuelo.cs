using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOReserva.Models.gestion_vuelo
{
    public class CGestion_Vuelo
    {
        public String _fechaAterrizaje { get; set; }
        public String _fechaDespegue { get; set; }
        public String _horaAterrizaje { get; set; }
        public String _horaDespegue { get; set; }
        public String _codigoVuelo { get; set; }
        public String _ciudadOrigen { get; set; }
        public String _matriculaAvion { get; set; }
        public int _pasajerosAvion { get; set; }
        public int _distanciaMaxima { get; set; }
        public String _ciudadDestino { get; set; }




    }
}