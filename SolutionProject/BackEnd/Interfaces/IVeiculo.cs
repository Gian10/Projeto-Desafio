using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Interfaces
{

    // INTERFACE RESPONSAVEL PELOS VEÍCLOS 
    public interface IVeiculo
    {
        public void CadastroVeiculo(Veiculo veiculo);

        public Veiculo ConsultarPlaca(string placa);

        public List<Veiculo> ConsultarMarcaFabricante(string marca);

        public List<Veiculo> ListarVeiculos();

        public void EditarVeiculo(Veiculo veiculo );

        public Veiculo BuscarVeiculoId(int id);

        public void ExcluirVeiculo(int id);

        public Boolean VerificarPlaca(string placa);
    }
}
