using Camada.DAL.Interfaces;
using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL.DAO.PessoasDAO
{
    class FuncionarioDAO : IFuncionario
    {

        ConexaoComBanco banco;

        public FuncionarioDAO()
        {
            banco = new ConexaoComBanco();
        }

        public bool Atualizar(Funcionario p)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Funcionario funcionarioobj)
        {
            
            Funcionario funcionario = new Funcionario();
        
            int i = 0;
            banco.AbrirConexao();
            try
            {

                string sql1 = string.Format(
               "INSERT INTO TB_Pessoa (CPF, RG, Nome, DataNasc, Sexo)" +
               "values ('{0}','{1}','{2}','{3}','{4}') SELECT SCOPE_IDENTITY()",
               funcionarioobj.cpf, funcionarioobj.rg, funcionarioobj.nome, funcionarioobj.dataNasc, funcionarioobj.sexo);

                int id = banco.ExecutarComandocomID(sql1);

                string sql = string.Format(
               "insert into TB_Endereco" +
               "(ENDE_Numero, ENDE_Comprimento, ENDE_Bairro, ENDE_Municipio, ENDE_Estado, ENDE_CEP, ENDE_Cidade, ID_Pessoa)" +
               "values" +
               "('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}')",
               funcionarioobj.endereco.ENDE_numero, funcionarioobj.endereco.ENDE_complemento, funcionarioobj.endereco.ENDE_bairro, funcionarioobj.endereco.municipio, funcionarioobj.endereco.estado, funcionarioobj.endereco.ENDE_cep, funcionarioobj.endereco.cidade, id);

                banco.ExecutarComandoSQL(sql);

                foreach (var tel in funcionarioobj.telefone)
                {
                       string telefone = string.Format(
                      "INSERT INTO TB_Telefone (Tel_DDI, Tel_DDD, Tel_Telefone, ID_PessoaTel)" +
                      "values ('{0}','{1}','{2}','{3}')",
                      tel.DDI, tel.DDD, tel.telefone, id);
                    banco.ExecutarComandoSQL(telefone);
                }


                string SQL_Funcionario = string.Format(
                     "INSERT INTO TB_Funcionario (ID_Perfil, ID_Pessoa, Salario)" +
                     "values ('{0}','{1}','{2}')",
                     funcionarioobj.perfil.id, id, funcionarioobj.salario );

                banco.ExecutarComandoSQL(SQL_Funcionario);

                banco.FecharConexao();
                return i >= 1;
            }
            catch (SqlException e)
            {
                Console.Write("Erro de Conexao SQL: " + e);
            }
            return false;

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
