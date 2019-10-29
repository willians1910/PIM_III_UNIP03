using Camada.DAL.Interfaces;
using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.DAO.PessoasDAO
{
    class MotoristaDAO : IMotorista
    {
        Motorista motorista = new Motorista();
        ConexaoComBanco Banco = new ConexaoComBanco();

        public bool Atualizar(Motorista m)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Motorista m)
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            throw new NotImplementedException();
        }
    }
}
