using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Veiculo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VeiculoId { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
    }
}
