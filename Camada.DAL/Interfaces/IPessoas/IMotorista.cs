using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.Interfaces
{
    public interface IMotorista
    {
        bool Inserir(Motorista m);

        DataSet Listar();

        bool Atualizar(Motorista m);

        bool Excluir(int codigo);
    }
}
