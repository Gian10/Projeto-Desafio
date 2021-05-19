using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{

    // INTERFACE RESPONSAVEL PELO REGISTRO DE MENUTENÇÕES

    public interface IRegistroManutencaoService
    {

        public void CadastroRegistroManutencao(RegistroManutencao registroManutencao);
    }
}
