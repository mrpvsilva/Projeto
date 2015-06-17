using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataSource.Infra.Context;
using Projeto.Util;

namespace Projeto.Controllers
{
    public class ServicoController : Controller
    {
        MyDbContext db = new MyDbContext();
        //
        // GET: /Servico/
        public ActionResult Index()
        {
            var os = db.OrdemServicos.AsQueryable();
            var u = Sessions.Usuario;

            if (u.GrupoUsuario.Descricao.Equals("Cliente"))
            {
                //os = os.Where(x => x.IdUsuario == u.IdUsuario);
            }
            return View(os);
        }
	}
}