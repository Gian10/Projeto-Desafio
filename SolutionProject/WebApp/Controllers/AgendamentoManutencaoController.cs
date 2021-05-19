using BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class AgendamentoManutencaoController : Controller
    {
        private IAgendamentoManutencaoService agendamentoManutencaoService;
        AgendamentoManutencao agendamento = new AgendamentoManutencao();


        public AgendamentoManutencaoController(IAgendamentoManutencaoService service)
        {
            this.agendamentoManutencaoService = service;
        }


        // GET: AgendamentoManutencaoController/Index
        public ActionResult Index()
        {
            var res = agendamentoManutencaoService.ConsultarManutencaoAgendadamento();
            
            return View(res);  
        }
        

        // GET: AgendamentoManutencaoController/Create
        public ActionResult Create()
        {
            
            agendamento.DataManutencao = DateTime.Today;
            return View(agendamento);
        }

        // POST: AgendamentoManutencaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var agendamento = new AgendamentoManutencao
                {
                    DataManutencao = DateTime.Parse(collection["DataManutencao"]),
                    PlacaVeiculo = collection["PlacaVeiculo"],
                    KmServico = int.Parse(collection["KmServico"]),
                    Servico = collection["Servico"]
                };
                agendamentoManutencaoService.CadastroAgendamentoManutencao(agendamento);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // Buscar agendamento de manutenção pela placa 
        public ActionResult ConsultarManutencaoPlaca(string placa)
        {
            if (placa == null)
            {
                return View();
            }
            var res = agendamentoManutencaoService.ConsultarManutencaoPlaca(placa);
            return View(res);
        }

    }
}
