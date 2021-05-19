using BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class VeiculoController : Controller
    {
        private IVeiculoService veiculoService; 

        public VeiculoController(IVeiculoService service)
        {
            this.veiculoService = service;
        }


        // GET: VeiculoController
        public ActionResult Index()
        {
            var result = veiculoService.ListarVeiculos();
            return View(result);
        }


        // GET: VeiculoController/Create
        public ActionResult Create()
        {     
            return View();
        }


        // POST: VeiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {         
                var veiculo = new Veiculo
                {
                    Nome = collection["Nome"],
                    Cor = collection["Cor"],
                    Modelo = collection["Modelo"],
                    AnoFabricacao = int.Parse(collection["AnoFabricacao"]),
                    Placa = collection["Placa"],
                    Marca = collection["Marca"],
                };

                var res = veiculoService.VerificarPlaca(veiculo.Placa);
                if (res == false)
                {
                    veiculoService.CadastroVeiculo(veiculo);
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Message = "PLACA JÁ CADASTRADA. TENTE UMA NOVA PLACA!";
                return View();
            }
            catch
            {
                return View();
            }
        }


        // GET: VeiculoController/Edit/5
        public ActionResult Edit(int id)
        {
            var res = veiculoService.BuscarVeiculoId(id);
            return View(res);
        }


        // POST: VeiculoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
           
                if (ModelState.IsValid)
                {
                var veiculo = new Veiculo
                {
                        VeiculoId = int.Parse(collection["VeiculoId"]),
                        Nome = collection["Nome"],
                        Cor = collection["Cor"],
                        Modelo = collection["Modelo"],
                        AnoFabricacao = int.Parse(collection["AnoFabricacao"]),
                        Placa = collection["Placa"],
                        Marca = collection["Marca"],
                    };
                    veiculoService.EditarVeiculo(veiculo);
                    return RedirectToAction(nameof(Index));
                   
                }
                return View(collection);      
        }


        // GET: VeiculoController/Delete/5
        public ActionResult Delete(int id)
        {
            veiculoService.ExcluirVeiculo(id);
            return RedirectToAction("Index");
        }


        // GET: Pagina inicial de pesquisa
        public ActionResult PesquisarPlaca()
        {
            return View();
        }


        // POST: Para buscar veículo com a placa pesquisada
        [HttpPost]
        public ActionResult PesquisarPlaca(string pesquisar)
        {
            var res = veiculoService.ConsultarPlaca(pesquisar);
            if (res != null)
            {
                return View(res);
            }
            ViewBag.Message = "NENHUMA PLACA ENCONTRADA!";
            return View();
        }


        // GET: Pagina inicial de pesquisa
        public ActionResult PesquisarMarcaFabricante()
        {
            return View();
        }


        // POST: Buscar veículos pela marca
        [HttpPost]
        public ActionResult PesquisarMarcaFabricante(string marca)
        {
           var res = veiculoService.ConsultarMarcaFabricante(marca); 
           return View(res);   
        }

    }
}
