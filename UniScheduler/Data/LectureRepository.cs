using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniScheduler.Models;
using Dapper;

namespace UniScheduler.Controllers
{
    public class LectureRepository 
    {
        private string _connectionString;

        public LectureRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["UniScheduler"].ConnectionString;
        }
        public IEnumerable<CourseLecturesModel> GetLecture() 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<CourseLecturesModel>("select * from CourseLectures INNER JOIN Teacher ON CourseLectures.TeacherId = Teacher.Id INNER JOIN Course ON CourseLectures.CourseId = Course.CId").ToList();
            }
        }
    }
}
