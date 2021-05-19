using BackEnd.Interfaces;
using BackEnd.Models;
using Itenso.TimePeriod;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Repositorios
{   // CLASSE DE REPOSITORIO DE AGENDAMENTO DE MANUTENÇÕES
    public class AgendamentoManutencaoRepositorio : IAgendamentoManutencao
    {

        private VeiculoContext veiculoContext;
        
        public AgendamentoManutencaoRepositorio()
        {

            this.veiculoContext = new VeiculoContext();
        }

        public void CadastroAgendamentoManutencao(AgendamentoManutencao agendamentoManutencao)
        {
            try
            {
                veiculoContext.agendamentoManutencao.Add(agendamentoManutencao);
                veiculoContext.SaveChanges();

            }
            catch (Exception)
            {

                throw new Exception("ERRO AO CADASTRAR AGENDAMENTO");
            }
        }

        public List<AgendamentoManutencao> ConsultarManutencaoAgendadamento()
        {
            try
            {

                List<AgendamentoManutencao> lista = new List<AgendamentoManutencao>();

                var resut = veiculoContext.agendamentoManutencao.ToList();

                // somar a data atual + 7 dias 
                var calculoData = DateTime.Now.AddDays(7).Day;

                foreach (var res in resut)
                {
                    // condição para buscar a data de agendamento se é com 7 dias de antecedência
                    if (res.DataManutencao.Day == calculoData)
                    {
                        lista.Add(res);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO LISTAR AGENDAMENTO DE MANUTENÇÃO");
            }
        }

        public List<AgendamentoManutencao> ConsultarManutencaoPlaca(string placa)
        {
            try
            {
                var res = veiculoContext.agendamentoManutencao.Where(x => x.PlacaVeiculo == placa).ToList();
                return res;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO BUSCAR PLACA DO VEÍCULO!");
            }
        }
    }
}
