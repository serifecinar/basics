using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
	public class CourseController : Controller
	{
		//course
		//course/index
		public IActionResult Index()
		{
			return View();
		}
		//course/list
		public string List()
		{
			return "course/list";
		}
	}
}
