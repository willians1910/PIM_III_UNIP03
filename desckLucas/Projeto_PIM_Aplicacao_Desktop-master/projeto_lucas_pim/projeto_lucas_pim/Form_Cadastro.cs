using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_lucas_pim
{
    public partial class formCadastro : Form
    {
        //Formulário Cadastro
        public formCadastro()
        {
            //Inicializa o formulário 
            InitializeComponent();

            CamposFuncionario_True();

            //CamposFuncionario_False(); Para iniciar já com o campos do funcionário

            CamposEmpresa_False();

            CamposMotorista_False();

            CamposVeiculos_False();


            // Dados da ComboBox Cargo
            cbCargo.Items.Add("Gerente");
            cbCargo.Items.Add("Administrativo");
            cbCargo.Items.Add("Estagiario");
            cbCargo.SelectedIndex = 0;

            // Dados da ComboBox Sexo
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.SelectedIndex = 1;

            // Dados da ComboBox Cores Veiculos
            cbCoresVeiculos.Items.Add("Vermelho");
            cbCoresVeiculos.Items.Add("Prata");
            cbCoresVeiculos.Items.Add("Cinza");
            cbCoresVeiculos.Items.Add("Branco");
            cbCoresVeiculos.Items.Add("Preto");

            // Dados da ComboBox Empresa do Motorista
            //cbEmpresaMot.Items.Add(""); //Aqui precisa vir de uma lista já cadastrado no banco

            // Dados da ComboBox Empresa do Veiculo
            //cbEmpresaVeiculos.Items.Add(""); //Aqui precisa vir de uma lista já cadastrado no banco

        }

        private void CamposEndereço_true()
        {
            lblRua.Visible = true;
            txtRua.Visible = true;

            lblNumeroResidencial.Visible = true;
            txtNumeroResidencial.Visible = true;

            lblComplemento.Visible = true;
            txtComplemento.Visible = true;

            lblBairro.Visible = true;
            txtBairro.Visible = true;

            lblMunicipio.Visible = true;
            txtMunicipio.Visible = true;

            lblCidade.Visible = true;
            txtCidade.Visible = true;

            lblEstado.Visible = true;
            txtEstado.Visible = true;

            lblCep.Visible = true;
            txtCEP.Visible = true;

        } //Campos endereços true

        private void CamposEndereço_fase()
        {
            lblRua.Visible = false;
            txtRua.Visible = false;

            lblNumeroResidencial.Visible = false;
            txtNumeroResidencial.Visible = false;

            lblComplemento.Visible = false;
            txtComplemento.Visible = false;

            lblBairro.Visible = false;
            txtBairro.Visible = false;

            lblMunicipio.Visible = false;
            txtMunicipio.Visible = false;

            lblCidade.Visible = false;
            txtCidade.Visible = false;

            lblEstado.Visible = false;
            txtEstado.Visible = false;

            lblCep.Visible = false;
            txtCEP.Visible = false;
        } // Campos endereços false

        private void CamposTelefone_true()
        {
            lblTelefone.Visible = true;
            txtTelefone.Visible = true;
        } //Campos telefones

        private void CamposTelefone_false()
        {
            lblTelefone.Visible = false;
            txtTelefone.Visible = false;
        }

        private void CamposFuncionario_True()  //Método para apresentar os campos do funcionário
        {
            lblCadastroTitulo.Text = "Funcionario";

            CamposEndereço_true();
            CamposTelefone_true();

            lblCPF.Visible = true;
            txtCPF.Visible = true;

            lblRG.Visible = true;
            txtRG.Visible = true;

            lbl_Nome.Visible = true;
            txtNome.Visible = true;

            lblDataNasc.Visible = true;
            dtNascimento.Visible = true;

            lblSexo.Visible = true;
            cbSexo.Visible = true;

            lblCargo.Visible = true;
            cbCargo.Visible = true;

        }

        private void CamposFuncionario_False() //Método para tirar os campos do funcionário
        {
            lblCPF.Visible = false;
            txtCPF.Visible = false;

            lblRG.Visible = false;
            txtRG.Visible = false;

            lbl_Nome.Visible = false;
            txtNome.Visible = false;

            lblDataNasc.Visible = false;
            dtNascimento.Visible = false;

            lblSexo.Visible = false;
            cbSexo.Visible = false;

            lblCargo.Visible = false;
            cbCargo.Visible = false;
        }

        private void CamposEmpresa_True() //Método para apresentar os campos da empresa
        {
            lblCadastroTitulo.Text = "Empresa";

            CamposEndereço_true();
            CamposTelefone_true();

            lblRazaoSocial.Visible = true;
            txtRazaoSocial.Visible = true;

            lblCPNJ.Visible = true;
            txtCNPJ.Visible = true;

            lblRG.Visible = true;
            txtRG.Visible = true;

            lblDataNasc.Visible = true;
            dtNascimento.Visible = true;

            lblSexo.Visible = true;
            cbSexo.Visible = true;

        }

        private void CamposEmpresa_False() //Método para tirar os campos da empresa
        {
            lblRazaoSocial.Visible = false;
            txtRazaoSocial.Visible = false;

            lblCPNJ.Visible = false;
            txtCNPJ.Visible = false;

        }

        private void CamposMotorista_True() //Método para apresentar os campos do motorista
        {
            lblCadastroTitulo.Text = "Motorista";

            CamposEndereço_fase();
            CamposTelefone_true();

            lblCNH.Visible = true;
            txtCNH.Visible = true;

            lbl_Nome.Visible = true;
            txtNome.Visible = true;

            lblRG.Visible = true;
            txtRG.Visible = true;

            lblDataNasc.Visible = true;
            dtNascimento.Visible = true;

            lblSexo.Visible = true;
            cbSexo.Visible = true;

            lblEmpresaMot.Visible = true;
            cbEmpresaMot.Visible = true;

            //Funcionario - Tirando os campos não utilizados por motorista ( Gambiarra )
            lblCPF.Visible = false;
            txtCPF.Visible = false;

            lblRG.Visible = false;
            txtRG.Visible = false;

        }

        private void CamposMotorista_False() //Método para tirar os campos do motorista
        {
            lblCNH.Visible = false;
            txtCNH.Visible = false;

            lblEmpresaMot.Visible = false;
            cbEmpresaMot.Visible = false;
        }

        private void CamposVeiculos_True() //Método para apresentar os campos de veículo
        {
            lblCadastroTitulo.Text = "Veiculos";

            lblPlaca.Visible = true;
            txtPlaca.Visible = true;

            lblMarca.Visible = true;
            txtMarca.Visible = true;

            lblModelo.Visible = true;
            txtModelo.Visible = true;

            lblRenavam.Visible = true;
            txtRenavam.Visible = true;

            lblMarca.Visible = true;
            txtMarca.Visible = true;

            lblCorVeiculo.Visible = true;
            cbCoresVeiculos.Visible = true;

            lblEmpresa.Visible = true;
            cbEmpresaVeiculos.Visible = true;
            
        }

        private void CamposVeiculos_False() //Método para tirar os campos dos veiculos
        {
            lblPlaca.Visible = false;
            txtPlaca.Visible = false;

            lblMarca.Visible = false;
            txtMarca.Visible = false;

            lblModelo.Visible = false;
            txtModelo.Visible = false;

            lblRenavam.Visible = false;
            txtRenavam.Visible = false;

            lblMarca.Visible = false;
            txtMarca.Visible = false;

            lblCorVeiculo.Visible = false;
            cbCoresVeiculos.Visible = false;

            lblEmpresa.Visible = false;
            cbEmpresaVeiculos.Visible = false;

        }
        
        //
       
        private void TPfuncionario_Click(object sender, EventArgs e) 
        {
            CamposFuncionario_True();

            CamposEmpresa_False();
            CamposMotorista_False();
            CamposVeiculos_False();

        } 

        private void TPempresa_Click(object sender, EventArgs e) 
        {
            CamposEmpresa_True();

            CamposFuncionario_False();
            CamposMotorista_False();
            CamposVeiculos_False();
        } 

        private void TPmotorista_Click_1(object sender, EventArgs e)
        {
            

            CamposMotorista_True();

            CamposEmpresa_False();
            CamposVeiculos_False();
            //CamposFuncionario_False(); //GAMBIARRA 
        }

        private void TPveiculo_Click(object sender, EventArgs e)
        {
            CamposVeiculos_True();
            CamposTelefone_false();

            CamposMotorista_False();
            CamposEmpresa_False();
            CamposFuncionario_False();

        }

        //

        private void Form_Cadastro_Load(object sender, EventArgs e)
        {

        }


            //Botão de Salvar, chamar funções
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
