using BackEnd.Interfaces;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Repositorios
{

    // CLASSE DE REPOSITORIO DE REGISTRO DE MANUTENÇÕES
    public class RegistroManutencaoRepositorio : IRegistroManutencao
    {

        private VeiculoContext registroManutencaoContex;

        public RegistroManutencaoRepositorio()
        {
            this.registroManutencaoContex = new VeiculoContext();
        }

        public void CadastroRegistroManutencao(RegistroManutencao registroManutencao)
        {
            try
            {         
                registroManutencaoContex.registroManutencaos.Add(registroManutencao);
                registroManutencaoContex.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO SALVAR REGISTRO DE MANUTENÇÃO");
            }
        }
    }
}
