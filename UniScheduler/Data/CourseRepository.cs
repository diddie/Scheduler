using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniScheduler.Models;
using Dapper;

namespace UniScheduler.Data
{
  public class CourseRepository
  {
    private string _connectionString;

    public CourseRepository()
    {
      _connectionString = ConfigurationManager.ConnectionStrings["UniScheduler"].ConnectionString;
    }

    public IEnumerable<CourseModel> GetCourses()
    {
      using (var connection = new SqlConnection(_connectionString))
      {
        connection.Open();

        return connection.Query<CourseModel>("select * from Course").ToList();
      }
    }
  }
}