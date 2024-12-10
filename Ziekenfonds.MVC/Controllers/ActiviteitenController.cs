using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ziekenfonds.MVC.DTOS;
using Ziekenfonds.MVC.Models;

namespace Ziekenfonds.MVC.Controllers
{
	public class ActiviteitenController: Controller
	{
		private readonly ILogger<ActiviteitenController> _logger;

		public ActiviteitenController(ILogger<ActiviteitenController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			// Controller haalt data op
			ActiveitenDTO activeitenDTO = new ActiveitenDTO
			{
				// Todo -> Data ophalen uit API ipv zelf te voorzien
				Beschrijving = "Hard gecodeerd",
				Naam = "Foobar"
			};


			return View(activeitenDTO);
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}