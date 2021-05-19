using BackEnd.Models;
using BackEnd.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class VeiculoService : IVeiculoService
    {
        private VeiculoRepositorio veiculoRepositorio;

        public VeiculoService()
        {
            this.veiculoRepositorio = new VeiculoRepositorio();
        }


        public Veiculo BuscarVeiculoId(int id)
        {        
            var res = veiculoRepositorio.BuscarVeiculoId(id);
            return res;
        }


        public void CadastroVeiculo(Veiculo veiculo)
        {     
            veiculoRepositorio.CadastroVeiculo(veiculo) ;  
        }


        public void EditarVeiculo(Veiculo veiculo)
        {
            veiculoRepositorio.EditarVeiculo(veiculo);  
        }


        public List<Veiculo> ListarVeiculos()
        {
            var veiculos = veiculoRepositorio.ListarVeiculos();
            return veiculos;
        }

        public void ExcluirVeiculo(int id)
        {
            veiculoRepositorio.ExcluirVeiculo(id);
        }

        public Veiculo ConsultarPlaca(string placa)
        {
            var res = veiculoRepositorio.ConsultarPlaca(placa);
            return res;
        }

        public List<Veiculo> ConsultarMarcaFabricante(string marca)
        {
            var res = veiculoRepositorio.ConsultarMarcaFabricante(marca);
            return res;
        }


        public bool VerificarPlaca(string placa)
        {
            var res = veiculoRepositorio.VerificarPlaca(placa);
            return res;
            
        }
    }
}
