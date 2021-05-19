using BackEnd.Interfaces;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Repositorios
{
    // CLASSE DE REPOSITORIO DE VEÍCULO
    public class VeiculoRepositorio : IVeiculo
    {

        private VeiculoContext veiculoContext;

        public VeiculoRepositorio()
        {
            this.veiculoContext = new VeiculoContext();
        }


        public Veiculo BuscarVeiculoId(int id)
        {
            try
            {
                var getVeciculoId = veiculoContext.veiculos.First(x => x.VeiculoId == id);
                return getVeciculoId;
            }
            catch (Exception ex)
            {
                throw new Exception("NENHUM VEÍCULO ENCONTRADO!");
            }
        }

        public void CadastroVeiculo(Veiculo veiculo)
        {
            try
            {
                veiculoContext.Add(veiculo);
                veiculoContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO CADASTRAR VEÍCULO!");
            }
            
        }


        public List<Veiculo> ConsultarMarcaFabricante(string marca)
        {
            try
            {
                var res = veiculoContext.veiculos.Where(x => x.Marca.Equals(marca)).OrderBy(x => x.Marca);
                return res.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO BUSCAR MARCA FABRICANTE");
            }
        }

        public Veiculo ConsultarPlaca(string placa)
        {
            try
            {
                var res = veiculoContext.veiculos.First(x => x.Placa == placa);
                return res;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

       


        public void EditarVeiculo(Veiculo veiculo)
        {
            try
            {
                veiculoContext.Entry(veiculo).State = EntityState.Modified;
                veiculoContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ATUALIZAR VEÍCULO!");
            }
        }


        public void ExcluirVeiculo(int id)
        {
            try
            {
                Veiculo veiculo = veiculoContext.veiculos.Find(id);
                veiculoContext.veiculos.Remove(veiculo);
                veiculoContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO DELETAR VEÍCULO!");
            }
        }


        public List<Veiculo> ListarVeiculos()
        {
            try
            {
                return this.veiculoContext.veiculos.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO LISTAR VEÍCULOS!");
            }
        }

        public bool VerificarPlaca(string placa)
        {
            try
            {
                var res = veiculoContext.veiculos.Any(x => x.Placa == placa);
                return res;     
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO VERIFICAR PLACA DO VEÍCULO!");
            }
        }
    }
}
