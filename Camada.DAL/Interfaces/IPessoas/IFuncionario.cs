using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.Interfaces
{
    public interface IFuncionario
    {
        bool Inserir(Funcionario pfuncionarioobj);

        DataSet Listar();

        bool Atualizar(Funcionario p);

        bool Excluir(int codigo);

        List<string> ListarPerfil();
    }
}
