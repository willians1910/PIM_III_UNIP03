using Camada.DAL.Interfaces;
using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.DAO.PessoasDAO
{
   public  class FuncionarioDAO : IFuncionario
    {
        ConexaoComBanco banco = new ConexaoComBanco();

        public bool Atualizar(Funcionario p)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int codigo)
        {
            throw new NotImplementedException();
        }
        private SqlConnection _con;
        private void Connection()
        {
            var constr = ConfigurationManager.ConnectionStrings["conexao"].ToString();

            _con = new SqlConnection(constr);
        }



        public bool Inserir(Funcionario f)
        {



            //string inserir = "INSERT INTO TB_Pessoa(ID_Cpf, RG, Nome, DataNasc, Sexo)";


            string inserirEnd = "INSERT INTO TB_Endereco(EMDE_CEP, ENDE_RUA, ENDE_Comprimento)" +
                "VALUES (123456, 'MANOEL MARQUES', 'B')";

            return true;
        }

        public DataSet Listar()
        {
            throw new NotImplementedException();
        }

        public List<string> ListarPerfil()
        {
            throw new NotImplementedException();
        }
    }
}
