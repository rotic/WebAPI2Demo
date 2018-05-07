using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            //扩展方法：启用WebAPI特性路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 自定义 路由，和mvc类似，增加action
            //config.Routes.MapHttpRoute(
            //    name: "customRoute1",
            //    routeTemplate: "myapi/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
