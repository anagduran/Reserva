using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOReserva.Models.gestion_vuelo;

namespace BOReserva.Controllers
{
    public class gestion_vueloController : Controller
    {
        //
        // GET: /gestion_vuelo/
        public ActionResult M04_GestionVuelo_Crear()
        {
            CGestion_Vuelo model = new CGestion_Vuelo();
            return PartialView(model);
        }

        [HttpPost]
        public JsonResult guardarVuelo(CGestion_Vuelo model)
        {
            String prueba = model._fechaDespegue;

            return (Json(true, JsonRequestBehavior.AllowGet));
        }
	}
}