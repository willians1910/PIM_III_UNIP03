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
    public partial class form_BuscaCadastros : Form
    {
        public form_BuscaCadastros()
        {
            InitializeComponent();
        }

        private void form_BuscaCadastros_Load(object sender, EventArgs e)
        {
            // Dados da ComboBox Busca
            cbTipoBusca.Items.Add("Funcionario");
            cbTipoBusca.Items.Add("Empresa");
            cbTipoBusca.Items.Add("Veiceulos");
            cbTipoBusca.Items.Add("Motorista");
            cbTipoBusca.SelectedIndex = 0;
        }
    }
}
