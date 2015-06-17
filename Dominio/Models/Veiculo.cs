using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        public string Tipo { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public string TipoServico { get; set; }

        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
