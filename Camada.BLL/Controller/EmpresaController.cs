using Camada.DAL.Interfaces;
using Camada.DTO.Clientes;
using System.Data;

namespace Camada.BLL.Controller
{
    class EmpresaController
    {
        private IEmpresa dao;

        public EmpresaController()
        {
            dao = DAOFactory.CriarEmpresaDAO();
        }

        public bool Inserir(Empresa e)
        {
            return dao.Inserir(e);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Empresa e)
        {
            return dao.Atualizar(e);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }

    }
}
