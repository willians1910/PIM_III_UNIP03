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
        ConexaoComBanco banco = new ConexaoComBanco();
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
            banco.ConexaoSQL();

            int i = 0;

            string sql = string.Format(
                       "insert into TB_Endereco (ENDE_Numero, ENDE_Comprimento, ENDE_Bairro, ENDE_Municipio, ENDE_Estado, Cidade," +
                       " values ('{0}','{1}','{2}','{3}','{4}','{5}') SELECT SCOPE_IDENTITY()",
                         funcionarioobj.endereco.ENDE_numero, funcionarioobj.endereco.ENDE_complemento, funcionarioobj.endereco.ENDE_bairro, funcionarioobj.endereco.municipio, funcionarioobj.endereco.estado, funcionarioobj.endereco.cidade,

                         "INSERT INTO TB_Pessoa (Cpf, RG, Nome, DataNasc, Sexo," + " values ('{0}','{1}','{2}','{3}','{4}') SELECT SCOPE_IDENTITY()",
                         funcionarioobj.cpf, funcionarioobj.rg, funcionarioobj.nome, funcionarioobj.dataNasc, funcionarioobj.sexo,

                          "INSERT INTO TB_Telefone (Tel_DDI, Tel_DDD, Tel_Telefone" + 
                          "VALUES ('{0}', '{1}', '{2}')",
                           funcionarioobj._Tel_DDI, funcionarioobj.Tel_DDD, funcionarioobj.Tel_telefone,

                             "INSERT INTO TB_Perfil ( Cargo, Salario" +
                             "VALUES ('{0}', '{1}')",
                              funcionarioobj.perfil.cargo, funcionarioobj.perfil.Salario);

           

            banco.cn.Open();

            try
            {
                banco.ExecutarSemConsulta(sql);

                banco.cn.Close();
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
