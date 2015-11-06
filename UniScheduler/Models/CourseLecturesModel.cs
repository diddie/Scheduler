using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniScheduler.Models
{
    public class CourseLecturesModel : TeacherModel
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Time { get; set; }
        public string Room { get; set; }

    }
}
