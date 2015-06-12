using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class GrupoUsuario
    {
        [Key]
        public int IdGrupoUsuario { get; set; }
        public string Descricao { get; set; }
        
    }
}
