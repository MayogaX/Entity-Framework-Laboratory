using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Dinamic_ConnectionString.Models;

namespace Dinamic_ConnectionString.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyDbContex db = new MyDbContex(((MyConnectionString)Session["MyConnectionString"]).ConnectionString);

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
