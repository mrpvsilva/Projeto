using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataSource.Infra.Context;
using Dominio.Models;
using Omu.ValueInjecter;
using Projeto.Models;
using Projeto.Util;

namespace Projeto.Controllers
{
    public class FuncionariosController : Controller
    {
        MyDbContext db = new MyDbContext();
        //
        // GET: /Funcionarios/
        public ActionResult Index()
        {

            var lista = (from user in db.Usuarios
                         orderby user.Nome
                         select user).ToList();
            return View(lista);
        }

        public ActionResult Novo()
        {
            ViewBag.grupos = db.GrupoUsuarios.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Value = x.IdGrupoUsuario.ToString(), Text = x.Descricao });

            return View();
        }

        [HttpPost]
        public ActionResult Novo(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("erro", "Falha ao cadastrar usuário");
                    return View(usuario);
                }
            }

            return View(usuario);
        }


    }
}