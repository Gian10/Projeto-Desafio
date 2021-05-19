using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class AgendamentoManutencao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgendamentoManutencaoId { get; set; }

        public DateTime DataManutencao { get; set; }

        public string PlacaVeiculo { get; set; }

        public string Servico { get; set; }

        public int? KmServico { get; set; }
    }
}
