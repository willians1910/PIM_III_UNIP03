using Camada.DAL.Interfaces;
using Camada.DTO.Veiculos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.BLL.Controller
{
    class VeiculoController
    {
        private IVeiculo dao;

        public VeiculoController()
        {
            dao = DAOFactory.CriarVeiculoDAO();
        }

        public bool Inserir(Veiculo v)
        {
            return dao.Inserir(v);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Veiculo v)
        {
            return dao.Atualizar(v);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }

    }
}
