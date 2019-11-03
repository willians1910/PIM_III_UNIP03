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

            string sql1 = string.Format("INSERT INTO TB_Pessoa (CPF, RG, Nome, DataNasc, Sexo) values ('{0}','{1}','{2}','{3}','{4}')",
                                        funcionarioobj.cpf, funcionarioobj.rg, funcionarioobj.nome, funcionarioobj.dataNasc, funcionarioobj.sexo);

            

            string sql = string.Format(
                       "insert into TB_Endereco (ENDE_Numero, ENDE_Comprimento, ENDE_Bairro, ENDE_Municipio, ENDE_Estado, Cidade,ID_Pessoa" +
                       "values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                         funcionarioobj.endereco.ENDE_numero, funcionarioobj.endereco.ENDE_complemento, funcionarioobj.endereco.ENDE_bairro, funcionarioobj.endereco.municipio, funcionarioobj.endereco.estado, funcionarioobj.endereco.cidade);

            //SELECT SCOPE_IDENTITY()


            banco.AbrirConexao();
            //string sql2 = string.Format("INSERT INTO TB_Telefone (Tel_DDI, Tel_DDD, Tel_Telefone" +
            //      "VALUES ('{0}', '{1}', '{2}')",
            //       funcionarioobj._Tel_DDI, funcionarioobj.Tel_DDD, funcionarioobj.Tel_telefone);

            //           string sql3 = string.Format("INSERT INTO TB_Perfil ( Cargo, Salario" +
            //                 "VALUES ('{0}', '{1}')",
            //                  funcionarioobj.perfil.cargo, funcionarioobj.perfil.Salario);



            //banco.cn.Open();

            try
            {
                banco.ExecutarComandoSQL(sql1);
                banco.ExecutarComandoSQL(sql);

                //banco.ExecutarSemConsulta(sql2);
                //banco.ExecutarSemConsulta(sql3);

                //banco.cn.Close();
                banco.FecharConexao();
                return i >= 1;
            }
            catch (SqlException e)
            {
                Console.Write("Erro de Conexao MySQL: " + e);
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
