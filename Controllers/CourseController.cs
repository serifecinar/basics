﻿using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
	public class CourseController : Controller
	{
		//course
		//course/index
		public string Index()
		{
			return "course/index";
		}
		//course/list
		public string List()
		{
			return "course/list";
		}
	}
}
