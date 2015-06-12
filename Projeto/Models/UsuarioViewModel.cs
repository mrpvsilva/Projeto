using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public int IdGrupoUsuario { get; set; }

        public GrupoUsuarioViewModel GrupoUsuario { get; set; }

        public UsuarioViewModel()
        {
            GrupoUsuario = new GrupoUsuarioViewModel();
        }
    }
}