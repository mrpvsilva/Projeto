using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataSource.Infra.Context;

namespace Projeto.Models
{
    public class FiltroUsuarioViewModel
    {
        public string Pesquisa { get; set; }
        public int Grupo { get; set; }

        public IEnumerable<SelectListItem> Grupos
        {
            get
            {
                var l = new MyDbContext().GrupoUsuarios.OrderBy(x => x.Descricao).Select(x => new SelectListItem { Value = x.IdGrupoUsuario.ToString(), Text = x.Descricao }).ToList();
                l.Insert(0, new SelectListItem { Text = "Todos", Value = "0", Selected = true });
                return l;
            }
        }


    }
}