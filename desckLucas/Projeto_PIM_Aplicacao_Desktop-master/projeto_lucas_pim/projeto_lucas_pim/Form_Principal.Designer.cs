namespace projeto_lucas_pim
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Location = new System.Drawing.Point(110, 66);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(80, 26);
            this.btn_Cadastro.TabIndex = 1;
            this.btn_Cadastro.Text = "Cadastro";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Busca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cadastro);
            this.Name = "Form_Principal";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Button button1;
    }
}

