using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Interfaces
{
    // INTERFACE RESPONSAVEL PELO AGENDAMENTO DE MANUTENÇÕES
    public interface IAgendamentoManutencao
    {

        public void CadastroAgendamentoManutencao(AgendamentoManutencao agendamentoManutencao);

        public List<AgendamentoManutencao> ConsultarManutencaoAgendadamento();

        public List<AgendamentoManutencao> ConsultarManutencaoPlaca(string placa);
    }
}
