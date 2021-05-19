using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Interfaces
{

    // INTERFACE RESPONSAVEL PELO REGISTRO DE MENUTENÇÕES
    public interface IRegistroManutencao
    {

        public void CadastroRegistroManutencao(RegistroManutencao registroManutencao);
    }
}
