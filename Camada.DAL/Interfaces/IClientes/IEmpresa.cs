using Camada.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.Interfaces
{
    public interface IEmpresa
    {
        bool Inserir(Empresa e);

        DataSet Listar();

        bool Atualizar(Empresa e);

        bool Excluir(int codigo);
    }
}
