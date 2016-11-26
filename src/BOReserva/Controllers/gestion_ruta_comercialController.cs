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
		// GET: gestion_ruta_comercial/M03_GestionRutasComerciales
		public PartialViewResult M03_GestionRutasComerciales()
		{
			CGestion_ruta ruta = new CGestion_ruta();
			return PartialView(ruta);
		}

		


	}   
		
}
