using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    /// <summary>
    /// Get各种请求的使用汇总
    /// </summary>
    [RoutePrefix("api/Student")]
    public class StudentController : ApiController
    {
        /// <summary>
        ///Get请求：无参数
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStudent")]
        public int GetStudent()
        {
            return 1400;
        }

        [Route("GetStudentInfo")]
        [HttpGet]
        public string GetStudentInfo(int id, string name)
        {
            return $"学员基本信息，姓名{name}，学号{id}";
        }

        [Route("QueryStudent")]
        [HttpGet]
        public string QueryStudent([FromUri]Student student)
        {
            return $"学员基本信息，姓名{student.StudentName}，学号{student.StudentId},电话号码{student.Telephone}";
        }

        [Route("GetStudentByJson")]
        [HttpGet]
        public string GetStudentByJson(string jsonStudent)
        {
            Student student = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(jsonStudent);
            return $"学员基本信息，姓名{student.StudentName}，学号{student.StudentId},电话号码{student.Telephone}";
        }

        [Route("QueryScore")]
        public string QueryScore(int studentId)
        {
            return $"获取到学号为{studentId}的成绩为88";
        }

        [Route("GetScore")]
        public string GetScore(int studentId)
        {
            return $"获取到学号为{studentId}的成绩为88";
        }

        [HttpGet]
        [Route("GetStudentList")]
        public List<Student> GetStudentList(string className)
        {
            return new List<Student>()
            {
                new Student(){StudentId=1001,StudentName="Killy",Telephone="15897396539"},
                new Student(){StudentId=1002,StudentName="Tom",Telephone="15897396549"},
                new Student(){StudentId=1003,StudentName="cindy",Telephone="15897396559"}
            };
        }
    }
}
