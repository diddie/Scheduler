using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniScheduler.Data;

namespace UniScheduler.Controllers
{
  public class LecturesController : Controller
  {

    public ActionResult Index()
    {
        var dataRepository = new LectureRepository();
        var lecture = dataRepository.GetLecture();

      return View(lecture);
    }

  }
}
