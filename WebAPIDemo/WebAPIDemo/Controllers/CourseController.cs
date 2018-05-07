using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    /// <summary>
    /// 基础API练习类
    /// </summary>
    public class CourseController : ApiController
    {
        [HttpGet]
        public string GetCourse()
        {
            //此处可以请求数据库或其他资源
            return "GetCourse()方法返回的结果：WebAPI 2开发技术";
        }

        [HttpGet]
        public string GetCourseById(int courseId)
        {
            return $"GetCourseById(int courseId)方法返回结果：课程ID={courseId}";
        }

        
        public string GetCourseByName()
        {
            return $"GetCourseByName(string courseId)方法返回结果!";
        }

        //特性路由1
        [HttpGet]
        [Route("Course/QueryCourse")]
        public string QueryCourse(int courseId)
        {
            //此处可以添加其他操作。。。
            return $"Get请求到的CourseID{courseId}";
        }

        //特性路由2
        [HttpPost]
        [Route("Course/UpdateCourse")]
        public string UpdateCourse()
        {
            //此处可以添加其他操作。。。
            return $"您正在修改课程";
        }

        //特性路由3
        [HttpPost]
        [Route("Course/DeleteCourse")]
        public string DeleteCourse([FromBody]int courseId)
        {
            //此处可以添加其他操作。。。
            return $"Post请求到的课程ID={courseId}";
        }

        //特性路由4
        [HttpPost]
        [Route("Course/AddCourse")]
        public string AddCourse([FromBody]Models.Course course)
        {
            //此处可以添加其他操作。。。
            return $"Post请求到的课程ID={course.Id},课程名称={course.CourseName},课程价格={course.Price}";
        }
    }
}
