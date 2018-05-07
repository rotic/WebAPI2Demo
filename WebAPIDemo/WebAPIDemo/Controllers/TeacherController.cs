using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    [RoutePrefix("api/Teacher")]
    public class TeacherController : ApiController
    {
        [Route("")]
        [HttpGet]
        public int GetAllTeahcerCount()
        {
            return 10;
        }

        [HttpPost]
        [Route("QueryTeacherById")]
        public string QueryTeacherById([FromBody]int teacherId)
        {
            return $"刘老师的讲师编号:{teacherId}";
        }

        //路由约束1
        [HttpGet]
        [Route("GetCount/{age:int=0}")]
        public string GetCount(int age)
        {
            return $"查询讲师年龄等于：{age}";
        }

        //路由约束2
        [HttpPost]
        [Route("GetTeacherName/{id:int=0}")]
        public string GetTeacherName([FromBody]int id)
        {
            return $"查询讲师编号等于：{id}";
        }
    }
}
