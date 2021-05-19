using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class RegistroManutencao
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistroManutencaoId { get; set; }

        public DateTime DataRegistroManutencao { get; set; }

        public string PlacaVeiculo { get; set; }

        public string Descricao { get; set; }

    }
}
