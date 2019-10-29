using Camada.DAL.Interfaces;
using Camada.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.DAO.PessoasDAO
{
  public class EmpresaDAO : IEmpresa
    {
        Empresa empresa = new Empresa();
        ConexaoComBanco banco = new ConexaoComBanco();

        public bool Atualizar(Empresa e)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Empresa e)
        {
           
            throw new NotImplementedException();

        }

        public DataSet Listar()
        {
            throw new NotImplementedException();
        }
    }
}
