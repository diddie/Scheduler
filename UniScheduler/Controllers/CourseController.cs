using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniScheduler.Data;

namespace UniScheduler.Controllers
{
  public class CourseController : Controller
  {
    public ActionResult Index()
    {
      var dataRepository = new CourseRepository();

      var courses = dataRepository.GetCourses();

      return View(courses);
    }
  }
}
