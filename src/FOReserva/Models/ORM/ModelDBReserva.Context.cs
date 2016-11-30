﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FOReserva.Models.ORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DBReserva : DbContext
    {
        public DBReserva()
            : base("name=DBReserva")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<M20_ActualizarEstadoReservaHabitacion_Result> M20_ActualizarEstadoReservaHabitacion(Nullable<int> id_reserva, Nullable<int> estado)
        {
            var id_reservaParameter = id_reserva.HasValue ?
                new ObjectParameter("id_reserva", id_reserva) :
                new ObjectParameter("id_reserva", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<M20_ActualizarEstadoReservaHabitacion_Result>("M20_ActualizarEstadoReservaHabitacion", id_reservaParameter, estadoParameter);
        }
    
        public virtual ObjectResult<M20_DetalleReservaHabitacion_Result> M20_DetalleReservaHabitacion(Nullable<int> id_reserva)
        {
            var id_reservaParameter = id_reserva.HasValue ?
                new ObjectParameter("id_reserva", id_reserva) :
                new ObjectParameter("id_reserva", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<M20_DetalleReservaHabitacion_Result>("M20_DetalleReservaHabitacion", id_reservaParameter);
        }
    
        public virtual ObjectResult<M20_GuardarReservaHabitacion_Result> M20_GuardarReservaHabitacion(Nullable<int> id_reserva, Nullable<int> habitacion, Nullable<int> cantidad_dias, Nullable<System.DateTime> fecha_reservada, Nullable<int> hot_id, Nullable<int> usu_id, Nullable<int> estado)
        {
            var id_reservaParameter = id_reserva.HasValue ?
                new ObjectParameter("id_reserva", id_reserva) :
                new ObjectParameter("id_reserva", typeof(int));
    
            var habitacionParameter = habitacion.HasValue ?
                new ObjectParameter("habitacion", habitacion) :
                new ObjectParameter("habitacion", typeof(int));
    
            var cantidad_diasParameter = cantidad_dias.HasValue ?
                new ObjectParameter("cantidad_dias", cantidad_dias) :
                new ObjectParameter("cantidad_dias", typeof(int));
    
            var fecha_reservadaParameter = fecha_reservada.HasValue ?
                new ObjectParameter("fecha_reservada", fecha_reservada) :
                new ObjectParameter("fecha_reservada", typeof(System.DateTime));
    
            var hot_idParameter = hot_id.HasValue ?
                new ObjectParameter("hot_id", hot_id) :
                new ObjectParameter("hot_id", typeof(int));
    
            var usu_idParameter = usu_id.HasValue ?
                new ObjectParameter("usu_id", usu_id) :
                new ObjectParameter("usu_id", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<M20_GuardarReservaHabitacion_Result>("M20_GuardarReservaHabitacion", id_reservaParameter, habitacionParameter, cantidad_diasParameter, fecha_reservadaParameter, hot_idParameter, usu_idParameter, estadoParameter);
        }
    
        public virtual ObjectResult<M20_HistorialReservaHabitacion_Result> M20_HistorialReservaHabitacion(Nullable<int> id_usuario)
        {
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<M20_HistorialReservaHabitacion_Result>("M20_HistorialReservaHabitacion", id_usuarioParameter);
        }
    }
}
