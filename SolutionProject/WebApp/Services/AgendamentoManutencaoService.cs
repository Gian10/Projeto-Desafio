using BackEnd.Models;
using BackEnd.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{

    // INTERFACE RESPONSAVEL PELO AGENDAMENTO DE MANUTENÇÕES
    public class AgendamentoManutencaoService : IAgendamentoManutencaoService
    {
        private AgendamentoManutencaoRepositorio agendamentoManutencaoRepositorio;

        public AgendamentoManutencaoService()
        {
            this.agendamentoManutencaoRepositorio = new AgendamentoManutencaoRepositorio();
        }


        public void CadastroAgendamentoManutencao(AgendamentoManutencao agendamentoManutencao)
        {
            agendamentoManutencaoRepositorio.CadastroAgendamentoManutencao(agendamentoManutencao);
        }

        public List<AgendamentoManutencao> ConsultarManutencaoAgendadamento()
        {
            return agendamentoManutencaoRepositorio.ConsultarManutencaoAgendadamento();
        }

        public List<AgendamentoManutencao> ConsultarManutencaoPlaca(string placa)
        {
            return agendamentoManutencaoRepositorio.ConsultarManutencaoPlaca(placa);
        }
    }
}
