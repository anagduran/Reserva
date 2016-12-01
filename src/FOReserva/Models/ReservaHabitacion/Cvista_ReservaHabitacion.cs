using FOReserva.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace FOReserva.Models.ReservaHabitacion
{
    using Usuario = TMPUsuario;
    using Errores;
    using Hotel = TMPHotel;

    public class Cvista_ReservaHabitacion
    {
        public enum EstadoReserva { Ocupando, Activo, Expiro, Cancelo }

        private Hotel hotel;
        private Usuario usuario;
        private int id;
        private int habitacion;
        private System.DateTime fechaReservada;
        private int cantidadDias;
        private Nullable<System.DateTime> fechaPartida;
        private EstadoReserva estado;

        public Hotel Hotel { get { return this.hotel; } }
        public Usuario Usuario { get { return this.usuario; } }
        public int Id { get { return this.id; } }
        public int Habitacion { get { return this.habitacion; } }
        public System.DateTime FechaReservada { get { return this.fechaReservada; } }
        public int CantidadDias { get { return this.cantidadDias; } }
        public Nullable<System.DateTime> FechaPartida { get { return this.fechaPartida; } }
        public EstadoReserva Estado { get { return this.estado; } }

        public Cvista_ReservaHabitacion() : base()
        {
            
        }

        public static List<Cvista_ReservaHabitacion> MisReservas(int usu_id) {

            try
            {
                var registros = from data in DB.Singleton().M20_HistorialReservaHabitacion(id_usuario: usu_id)
                                select new Cvista_ReservaHabitacion
                                {
                                    hotel = new Hotel
                                    {
                                        Codigo = data.hot_id
                                    },
                                    usuario = new Usuario
                                    {
                                        Codigo = usu_id
                                    },
                                    id = data.rha_id,
                                    habitacion = data.rha_habitacion,
                                    cantidadDias = data.rha_cantidad_dias,
                                    fechaReservada = data.rha_fecha_reservada,
                                    fechaPartida = data.rha_fecha_partida,
                                    estado = (EstadoReserva)data.rha_estado
                                };

                return registros.ToList();
            }
            catch (Exception ex) {
                Utilidad.RegistrarLog(new ReservaHabitacionException("Ocurrio un problema al obtener mis reservas.", ex));
            }
            return null;
        }
    }
}