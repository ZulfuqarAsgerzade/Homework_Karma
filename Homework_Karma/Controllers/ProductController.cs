using Microsoft.AspNetCore.Mvc;

namespace Homework_Karma.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Details()
		{
			return View();
		}
	}
}
