using Camada.DAL;
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
   public  class FuncionarioController
    {
        private IFuncionario  dao;

        public FuncionarioController()
        {
            dao = DAOFactory.CriarFuncioarioDAO();
        }

        public bool Inserir(Funcionario funcionarioobj)
        {
            return dao.Inserir(funcionarioobj);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Funcionario f)
        {
            return dao.Atualizar(f);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }

        public List<string> ListarPerfil()
        {
            return dao.ListarPerfil();
        }

    }
}
