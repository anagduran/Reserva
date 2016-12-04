using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOReserva.Models.gestion_ruta_comercial;

namespace BOReserva.Controllers
{
    public class gestion_ruta_comercialController : Controller
    {
        //
        // GET: gestion_ruta_comercial/AgregarRutasComerciales
        public PartialViewResult AgregarRutasComerciales()
        {
            CGestion_ruta ruta = new CGestion_ruta();
            return PartialView(ruta);
        }


        // GET: gestion_ruta_comercial/ModificarRutasComerciales
        public PartialViewResult ModificarRutasComerciales()
        {
            CGestion_ruta ruta = new CGestion_ruta();
            return PartialView(ruta);
        }


        // GET: gestion_ruta_comercial/VisualizarRutasComerciales
        public PartialViewResult VisualizarRutasComerciales()
        {
            CGestion_ruta ruta = new CGestion_ruta();
            return PartialView(ruta);
        }

        // GET: gestion_ruta_comercial/VisualizarRutasComerciales
        public PartialViewResult DetalleRutasComerciales()
        {
            CGestion_ruta ruta = new CGestion_ruta();
            return PartialView(ruta);
        }

    }   
}
