using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
	public class EquipmentController:Controller
	{
		public EquipmentController()
		{

		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
