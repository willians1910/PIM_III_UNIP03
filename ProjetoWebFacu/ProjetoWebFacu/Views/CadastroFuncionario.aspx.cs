﻿using Camada.BLL.Controller;
using Camada.DTO;
using Camada.DTO.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWebFacu
{
    public partial class CadastroFuncionario : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void salvarButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void SalvarButton_Click(object sender, EventArgs e) //esse
        {
            try
            {
                FuncionarioController salvar = new FuncionarioController();
                Funcionario funcionario = new Funcionario();


                
                funcionario.endereco.ENDE_numero = Convert.ToInt32(NumeroTextBox.Text);
                funcionario.endereco.ENDE_complemento = ComprimentoTextBox.Text;
                funcionario.endereco.ENDE_bairro = BairroTextBox.Text;
                funcionario.endereco.municipio = MunicipioTextBox2.Text;
                funcionario.endereco.estado = EstadoTextBox3.Text;
                funcionario.endereco.cidade = CidadeTextBox2.Text;
                funcionario.cpf = Convert.ToInt32(cpfTextBox.Text);
                funcionario.rg = RgTextBox.Text;
                funcionario.nome = NomeTextBox.Text;
                funcionario.dataNasc = Convert.ToDateTime(DatanascTextBox2.Text);
                funcionario.sexo = SexoTextBox.Text;
                funcionario._Tel_DDI = Convert.ToInt32(DddTextBox2.Text);
                funcionario.Tel_DDD= Convert.ToInt32(TelefoneTextBox.Text);
                funcionario.Tel_telefone = Convert.ToInt32(TelefoneTextBox.Text);
                funcionario.perfil.cargo = CargoTextBox.Text;
                funcionario.perfil.Salario = Convert.ToDecimal(SalarioTextBox.Text);

                salvar.Inserir(funcionario);

            }
            catch (Exception ex)
            {

                salvarLabel1.Text = ex.Message;

            }

        }
 
    }
}