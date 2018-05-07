using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [RoutePrefix("api/Score")]
    public class ScoreController : ApiController
    {
        [HttpPost]
        [Route("GetScoreById")]
        public string GetScoreById([FromBody]int id)
        {
            return $"POST请求一个参数返回信息：ID：{id}，csharp：80，DB：98";
        }

        [HttpPost]
        [Route("GetScoreByIdAndName")]//无法实现，不能绑定多个参数
        public string GetScoreByIdAndName([FromBody]int id,[FromBody]string name)
        {
            return $"POST请求两个参数返回信息：ID：{id}，Name:{name},csharp：80，DB：98";
        }

        [HttpPost]
        [Route("GetScoreByDynamic")]
        public string GetScoreByDynamic(dynamic param)
        {
            return $"POST请求两个参数基于Dynamic返回信息：ID：{param.id}，Name:{param.name},csharp：80，DB：98";
        }

        [HttpPost]
        [Route("QueryStudent")]
        public string QueryStudent(Student student)
        {
            return $"POST基于JSON传递实体请求返回信息：{student.StudentName}";
        }

        [HttpPost]
        [Route("MultiParam")]
        public string MultiParam(dynamic param)
        {
            //方式一.通过key动态的获取对应数据，并根据需要进行转换
            var teacher = param.Teacher.ToString();
            var course = Newtonsoft.Json.JsonConvert.DeserializeObject<Course>(param.Course.ToString());

            //方式二.对应动态类型中包括的子对象也可以通过jObject类型转换
            Newtonsoft.Json.Linq.JObject jObject = param.Course;
            var courseModel = jObject.ToObject<Course>();

            return $"Teacher={teacher} CourseName={course.CourseName} CoursePrice={course.Price} CourseId={course.Id}";
        }

        [HttpPost]
        [Route("ArrayParam")]
        public string ArrayParam(string[] param)
        {
            return $"{param[0]},{param[1]},{param[2]}";
        }

        //实体集合
        [HttpPost]
        [Route("ListParam")]
        public string ListParam( List<Student> students)
        {
            return students.Count.ToString();
        }

        //PUT请求（主要用于对象的更新，用法与get和post相同，也就是支持FromBody，FromUri，Dynamic）
        [HttpPut]
        [Route("PutStudent")]
        public Student PutStudent()
        {
            //在这里编写其他逻辑
            return new Student() { StudentId = 10011, StudentName = "习近平", Telephone = "18888888888" };
        }

        [HttpDelete]
        [Route("DeleteStudent")]
        public string DeleteStudent(Student student)
        {
            //在这里编写其他逻辑
            return $"删除学员的信息:{student.StudentName}";
        }
    }
}
