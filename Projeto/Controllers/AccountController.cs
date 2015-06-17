using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataSource.Infra.Context;
using Dominio.Models;
using Projeto.Models;
using Projeto.Util;
using Omu.ValueInjecter;

namespace Projeto.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var db = new MyDbContext();

                var u = db.Usuarios.FirstOrDefault(x => x.Login == usuario.Login && x.Senha == usuario.Senha);

                if (u != null)
                {
                    Sessions.Usuario = u;
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("erro", "Login ou senha inválidos");
                return View(usuario);
            }

            return View(usuario);
        }


        public ActionResult Sair()
        {
            HttpContext.Session.RemoveAll();
            return RedirectToAction("Login");
        }
    }
}