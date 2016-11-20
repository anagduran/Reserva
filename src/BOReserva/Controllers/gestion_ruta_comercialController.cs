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
        // GET: /gestion_ruta_comercial/
        public ActionResult M03_GestionRutasComerciales()
        {
            CGestion_ruta modelo = new CGestion_ruta();
            
            return PartialView(modelo);
        }

        //
        //POST:
        [HttpPost]
        public JsonResult guardarRuta(CGestion_ruta modelo)
        {
            String origen = modelo._origenRutaAgregar;
            return (Json(true, JsonRequestBehavior.AllowGet));
        }
	}   
        
}
