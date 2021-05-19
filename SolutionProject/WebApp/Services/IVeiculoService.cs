using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{

    // INTERFACE RESPONSAVEL PELOS VEÍCLOS 

    public interface IVeiculoService
    {
        public List<Veiculo> ListarVeiculos();

        public void CadastroVeiculo(Veiculo veiculo);

        public void EditarVeiculo(Veiculo veiculo);

        public Veiculo BuscarVeiculoId(int id);

        public void ExcluirVeiculo(int id);

        public Veiculo ConsultarPlaca(string placa);

        public List<Veiculo> ConsultarMarcaFabricante(string marca);

        public Boolean VerificarPlaca(string placa);

    }
}
