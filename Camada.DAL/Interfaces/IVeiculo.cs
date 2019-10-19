using Camada.DTO.Veiculos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.Interfaces
{
    public interface IVeiculo
    {
        bool Inserir(Veiculo v);

        DataSet Listar();

        bool Atualizar(Veiculo v);

        bool Excluir(int codigo);
    }
}
