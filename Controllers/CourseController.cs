using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
	public class CourseController : Controller
	{
		//course
		//course/index
		public IActionResult Index()
		{
			var kurs = new Course();
			kurs.Id = 1;
			kurs.Title = "Aspnet cor kursu";
			kurs.Description = "Güzel bir kurs";
			return View(kurs);
		}

		//course/list
		public IActionResult List()
		{
			return View();
		}
	}
}
