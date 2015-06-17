using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class OrdemServico
    {
        [Key]
        public int IdOrdemServico { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEntrada { get; set; }
        public string Descricao { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DataSaida { get; set; }
        public int IdVeiculo { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}
