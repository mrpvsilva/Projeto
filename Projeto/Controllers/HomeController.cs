using DataSource.Infra.Context;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Util;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = Sessions.Usuario;

            if (user == null)
                return RedirectToAction("Login","Account");


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}