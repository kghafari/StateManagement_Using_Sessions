using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Day27_StateManagement_Sessions.Models;
using Microsoft.AspNetCore.Http;

namespace Day27_StateManagement_Sessions.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveUserName(string userName)
        {
            //session magic:
            //Going into the HttpContext Class, to the Session property
            //using the STATIC method called SetString to add a key value
            //pair to our Session class
            HttpContext.Session.SetString("SessionName", userName); //creates a NEW session
            return View("Index");
        }

    }
}

//PUT THIS IN STARTUP UNDER ConfigureServices to enable/use sessions
//services.AddSession(
//                options =>
//                {
//                    options.IdleTimeout = TimeSpan.FromSeconds(10);
//                    options.Cookie.HttpOnly = true;
//                    options.Cookie.IsEssential = true;
//                }
//            );


//// add this for reasons in the Configure method (under startup)
//app.UseSession();
