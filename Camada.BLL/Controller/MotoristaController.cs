using Camada.DAL.Interfaces;
using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.BLL.Controller
{
    class MotoristaController
    {
        private IMotorista dao;

        public MotoristaController()
        {
            dao = DAOFactory.CriarMotoristaDAO();
        }

        public bool Inserir(Motorista m)
        {
            return dao.Inserir(m);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Motorista m)
        {
            return dao.Atualizar(m);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }

    }
}
