﻿using Microsoft.Practices.Unity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;
using TriscalDesafioDesenvolvedor.Infra.IoC;
using TriscalDesafioDesenvolvedor.UI.App_Start;

namespace TriscalDesafioDesenvolvedor.UI
{
    public static class WebApiConfig
    {
          
        public static void Register(HttpConfiguration config)
        {

           


            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                  routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


      



         
            // use json strings as the default return value for the app
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();
           
         
        }
    }
}
