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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            new formCadastro().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new form_BuscaCadastros().ShowDialog();
        }
    }
}
