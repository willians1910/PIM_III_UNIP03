using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL
{
    public class ConexaoComBanco
    {
        // objeto de conexão com o SQL
        private SqlConnection conexao;
        protected SqlCommand cmd;


        public ConexaoComBanco()
        {
            Inicializar();
        }

        public void Inicializar()
        {
            if (conexao == null)
            {
                // string de conexão com o MySQL obtida do arquivo App.config
                string constr = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;

                conexao = new SqlConnection(constr);
            }
        }

        public bool AbrirConexao()
        {

            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                }
                return true;
            }
            catch (SqlException e)
            {
                //MessageBox.Show("Erro de Conexao MySQL: " + e) MYSQL;
                //MessageBox.Show("Erro de Conexão SQLServer" + e);
            }
            return false;
        }

        public bool FecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (SqlException e)
            {
                //MessageBox.Show("Erro ao fechar Conexao SQLServer: " + e);-
                Console.WriteLine(e);

            }
            return false;
        }

        public void ExecutarComandoSQL(string sql)
        {
            if (AbrirConexao() == true)
            {
             
                cmd = new SqlCommand(sql, conexao);
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine("Executado :", i);
                FecharConexao();
            }

        }
        //RETORNA O ULTIMO ID ADICIONADO
        public int ExecutarComandocomID(string sql)
        {
            //MensagemErro = "";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);
                Int32 id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception e)
            {
                //MensagemErro = "Método: ExecutarComando()\nErro: " + e.Message;
                Console.WriteLine("Erro :", e);
                return -1;
            }
        }


    }
}