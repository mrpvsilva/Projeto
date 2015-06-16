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
        public ActionResult Index(FiltroUsuarioViewModel filtro)
        {

            var lista = (from user in db.Usuarios select user);


            if (!string.IsNullOrEmpty(filtro.Pesquisa))
                lista =
                    lista.Where(
                        x => x.Nome.Contains(filtro.Pesquisa) || x.GrupoUsuario.Descricao.Contains(filtro.Pesquisa));

            if (filtro.Grupo != 0)
                lista = lista.Where(x => x.IdGrupoUsuario == filtro.Grupo);


            lista = lista.OrderBy(x => x.Nome);

            return View(lista.ToList());
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


        public ActionResult Alterar(int id)
        {
            var u = db.Usuarios.Find(id);
            ViewBag.grupos = db.GrupoUsuarios.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Value = x.IdGrupoUsuario.ToString(), Text = x.Descricao });
            return View(u);
        }

        [HttpPost]
        public ActionResult Alterar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var u = db.Usuarios.Find(usuario.IdUsuario);
                    u.InjectFrom(usuario);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("erro", "Falha ao alterar usuário");
                    return View(usuario);
                }
            }
            return View(usuario);
        }



        public ActionResult Excluir(int id)
        {
            var u = db.Usuarios.Find(id);
            return View(u);

        }

        [HttpPost, ActionName(name: "Excluir")]
        public ActionResult ExcluirUsuario(int id)
        {
            var u = db.Usuarios.Find(id);
            db.Usuarios.Remove(u);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult Visualizar(int id)
        {
            var u = db.Usuarios.Find(id);
            return View(u);
        }

    }
}