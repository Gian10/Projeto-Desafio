using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class VeiculoContext : DbContext
    {
        public DbSet<Veiculo> veiculos { get; set;}

        public DbSet<RegistroManutencao> registroManutencaos { get; set; }

        public DbSet<AgendamentoManutencao> agendamentoManutencao { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=ProjetoVeiculo; Trusted_Connection = true");
        }
    }
}
