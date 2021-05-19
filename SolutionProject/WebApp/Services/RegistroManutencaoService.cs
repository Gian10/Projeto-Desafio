using BackEnd.Models;
using BackEnd.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class RegistroManutencaoService : IRegistroManutencaoService
    {
        private RegistroManutencaoRepositorio registroManutencaoRepositorio;

        public RegistroManutencaoService()
        {
            this.registroManutencaoRepositorio = new RegistroManutencaoRepositorio();

        }


        public void CadastroRegistroManutencao(RegistroManutencao registroManutencao)
        {
            registroManutencaoRepositorio.CadastroRegistroManutencao(registroManutencao);
        }
    }
}
