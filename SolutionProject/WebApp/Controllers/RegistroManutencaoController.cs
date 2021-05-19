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
    public class RegistroManutencaoController : Controller
    {
        private IRegistroManutencaoService registroManutencaoService;

        public RegistroManutencaoController(IRegistroManutencaoService service)
        {
            this.registroManutencaoService = service;

        }


        // GET: RegistroManutencaoController/Index
        public ActionResult Index()
        {
            return View();
        }

       

        // GET: RegistroManutencaoController/Create
        public ActionResult Create()
        {
            RegistroManutencao registroManutencao = new RegistroManutencao();
            // exibir a data atual
            registroManutencao.DataRegistroManutencao = DateTime.Today;    
            return View(registroManutencao);
        }

        // POST: RegistroManutencaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var registro = new RegistroManutencao
                {
                    DataRegistroManutencao = DateTime.Parse(collection["DataRegistroManutencao"]),
                    PlacaVeiculo = collection["PlacaVeiculo"],
                    Descricao = collection["Descricao"]
                };
                registroManutencaoService.CadastroRegistroManutencao(registro);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

       
       
    }
}
