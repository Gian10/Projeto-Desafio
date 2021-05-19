using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{

    // INTERFACE RESPONSAVEL PELO AGENDAMENTO DE MANUTENÇÕES
    public interface IAgendamentoManutencaoService
    {

        public void CadastroAgendamentoManutencao(AgendamentoManutencao agendamentoManutencao);

        public List<AgendamentoManutencao> ConsultarManutencaoAgendadamento();

        public List<AgendamentoManutencao> ConsultarManutencaoPlaca(string placa);

    }
}
