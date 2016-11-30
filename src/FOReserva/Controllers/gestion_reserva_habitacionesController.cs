﻿using FOReserva.Models.ReservaHabitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FOReserva.Controllers
{
    public class gestion_reserva_habitacionesController : Controller
    {
        //
        // GET: /gestion_reserva_habitaciones/

        [HttpGet]
        public ActionResult mis_reservas()
        {
            List<Cvista_ReservaHabitacion> model = new List<Cvista_ReservaHabitacion>();
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult detalle_reserva(Cvista_ReservaHabitacion model)
        {            
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult editar_reserva(Cvista_ReservaHabitacion model)
        {            
            return PartialView(model);
        }

        [HttpPost]
        public JsonResult guardar_reserva()
        {
            return Json(new { hubo_problemas = false, mensaje = "Reserva guardada..." }, JsonRequestBehavior.AllowGet);
        }



    }
}