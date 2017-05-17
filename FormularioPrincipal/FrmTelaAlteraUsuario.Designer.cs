namespace FormularioPrincipal
{
    partial class FrmTelaAlteraUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFrmAlteraUsuario_BuscarUsuario = new System.Windows.Forms.Button();
            this.txtFrmAlteraUsuario_buscarNomeUsuario = new System.Windows.Forms.TextBox();
            this.lbFrmAlteraUsuario_buscarNomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrmAlteraUsuario_confirmaAlteracao = new System.Windows.Forms.Button();
            this.dataGridView_AlteraUsuario = new System.Windows.Forms.DataGridView();
            this.pnCadUsuario = new System.Windows.Forms.Panel();
            this.comboBoxAlteraUsuario_tipoPerfil = new System.Windows.Forms.ComboBox();
            this.chkboxfrmCadUsuario_usuarioAtivo = new System.Windows.Forms.CheckBox();
            this.lbFrmCadUsuario_tipoPerfil = new System.Windows.Forms.Label();
            this.lbFrmAlteraUsuario_loginUsuario = new System.Windows.Forms.Label();
            this.lbFrmAlteraUsuario_nomeUsuario = new System.Windows.Forms.Label();
            this.txtFrmAlteraUsuario_loginUsuario = new System.Windows.Forms.TextBox();
            this.txtFrmAlteraUsuario_nomeUsuario = new System.Windows.Forms.TextBox();
            this.btnFrmAlteraUsuario_resetSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlteraUsuario)).BeginInit();
            this.pnCadUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrmAlteraUsuario_BuscarUsuario
            // 
            this.btnFrmAlteraUsuario_BuscarUsuario.Location = new System.Drawing.Point(479, 42);
            this.btnFrmAlteraUsuario_BuscarUsuario.Name = "btnFrmAlteraUsuario_BuscarUsuario";
            this.btnFrmAlteraUsuario_BuscarUsuario.Size = new System.Drawing.Size(71, 25);
            this.btnFrmAlteraUsuario_BuscarUsuario.TabIndex = 7;
            this.btnFrmAlteraUsuario_BuscarUsuario.Text = "Buscar";
            this.btnFrmAlteraUsuario_BuscarUsuario.UseVisualStyleBackColor = true;
            this.btnFrmAlteraUsuario_BuscarUsuario.Click += new System.EventHandler(this.btnFrmAlteraUsuario_BuscarUsuario_Click);
            // 
            // txtFrmAlteraUsuario_buscarNomeUsuario
            // 
            this.txtFrmAlteraUsuario_buscarNomeUsuario.Location = new System.Drawing.Point(326, 45);
            this.txtFrmAlteraUsuario_buscarNomeUsuario.Name = "txtFrmAlteraUsuario_buscarNomeUsuario";
            this.txtFrmAlteraUsuario_buscarNomeUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtFrmAlteraUsuario_buscarNomeUsuario.TabIndex = 6;
            this.txtFrmAlteraUsuario_buscarNomeUsuario.TextChanged += new System.EventHandler(this.txtFrmAlteraUsuario_nomeUsuario_TextChanged);
            // 
            // lbFrmAlteraUsuario_buscarNomeUsuario
            // 
            this.lbFrmAlteraUsuario_buscarNomeUsuario.AutoSize = true;
            this.lbFrmAlteraUsuario_buscarNomeUsuario.Location = new System.Drawing.Point(182, 48);
            this.lbFrmAlteraUsuario_buscarNomeUsuario.Name = "lbFrmAlteraUsuario_buscarNomeUsuario";
            this.lbFrmAlteraUsuario_buscarNomeUsuario.Size = new System.Drawing.Size(124, 13);
            this.lbFrmAlteraUsuario_buscarNomeUsuario.TabIndex = 5;
            this.lbFrmAlteraUsuario_buscarNomeUsuario.Text = "Digite o nome do usuário";
            this.lbFrmAlteraUsuario_buscarNomeUsuario.Click += new System.EventHandler(this.lbFrmAlteraUsuario_nomeUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alterar Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFrmAlteraUsuario_confirmaAlteracao
            // 
            this.btnFrmAlteraUsuario_confirmaAlteracao.Location = new System.Drawing.Point(551, 384);
            this.btnFrmAlteraUsuario_confirmaAlteracao.Name = "btnFrmAlteraUsuario_confirmaAlteracao";
            this.btnFrmAlteraUsuario_confirmaAlteracao.Size = new System.Drawing.Size(131, 23);
            this.btnFrmAlteraUsuario_confirmaAlteracao.TabIndex = 13;
            this.btnFrmAlteraUsuario_confirmaAlteracao.Text = "Confirmar Alteração";
            this.btnFrmAlteraUsuario_confirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnFrmAlteraUsuario_confirmaAlteracao.Click += new System.EventHandler(this.btnFrmAlteraUsuario_confirmaAlteracao_Click);
            // 
            // dataGridView_AlteraUsuario
            // 
            this.dataGridView_AlteraUsuario.AllowUserToAddRows = false;
            this.dataGridView_AlteraUsuario.AllowUserToDeleteRows = false;
            this.dataGridView_AlteraUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AlteraUsuario.Location = new System.Drawing.Point(34, 76);
            this.dataGridView_AlteraUsuario.Name = "dataGridView_AlteraUsuario";
            this.dataGridView_AlteraUsuario.ReadOnly = true;
            this.dataGridView_AlteraUsuario.Size = new System.Drawing.Size(648, 120);
            this.dataGridView_AlteraUsuario.TabIndex = 14;
            this.dataGridView_AlteraUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AlteraUsuario_CellContentClick_1);
            this.dataGridView_AlteraUsuario.SelectionChanged += new System.EventHandler(this.dataGridView_AlteraUsuario_SelectionChanged);
            // 
            // pnCadUsuario
            // 
            this.pnCadUsuario.Controls.Add(this.comboBoxAlteraUsuario_tipoPerfil);
            this.pnCadUsuario.Controls.Add(this.chkboxfrmCadUsuario_usuarioAtivo);
            this.pnCadUsuario.Controls.Add(this.lbFrmCadUsuario_tipoPerfil);
            this.pnCadUsuario.Controls.Add(this.lbFrmAlteraUsuario_loginUsuario);
            this.pnCadUsuario.Controls.Add(this.lbFrmAlteraUsuario_nomeUsuario);
            this.pnCadUsuario.Controls.Add(this.txtFrmAlteraUsuario_loginUsuario);
            this.pnCadUsuario.Controls.Add(this.txtFrmAlteraUsuario_nomeUsuario);
            this.pnCadUsuario.Location = new System.Drawing.Point(63, 202);
            this.pnCadUsuario.Name = "pnCadUsuario";
            this.pnCadUsuario.Size = new System.Drawing.Size(649, 176);
            this.pnCadUsuario.TabIndex = 15;
            this.pnCadUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCadUsuario_Paint);
            // 
            // comboBoxAlteraUsuario_tipoPerfil
            // 
            this.comboBoxAlteraUsuario_tipoPerfil.FormattingEnabled = true;
            this.comboBoxAlteraUsuario_tipoPerfil.Items.AddRange(new object[] {
            "A",
            "E"});
            this.comboBoxAlteraUsuario_tipoPerfil.Location = new System.Drawing.Point(122, 94);
            this.comboBoxAlteraUsuario_tipoPerfil.Name = "comboBoxAlteraUsuario_tipoPerfil";
            this.comboBoxAlteraUsuario_tipoPerfil.Size = new System.Drawing.Size(37, 21);
            this.comboBoxAlteraUsuario_tipoPerfil.TabIndex = 12;
            this.comboBoxAlteraUsuario_tipoPerfil.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipoPerfil_SelectedIndexChanged);
            // 
            // chkboxfrmCadUsuario_usuarioAtivo
            // 
            this.chkboxfrmCadUsuario_usuarioAtivo.AutoSize = true;
            this.chkboxfrmCadUsuario_usuarioAtivo.Location = new System.Drawing.Point(325, 98);
            this.chkboxfrmCadUsuario_usuarioAtivo.Name = "chkboxfrmCadUsuario_usuarioAtivo";
            this.chkboxfrmCadUsuario_usuarioAtivo.Size = new System.Drawing.Size(89, 17);
            this.chkboxfrmCadUsuario_usuarioAtivo.TabIndex = 11;
            this.chkboxfrmCadUsuario_usuarioAtivo.Text = "Usuario Ativo";
            this.chkboxfrmCadUsuario_usuarioAtivo.UseVisualStyleBackColor = true;
            this.chkboxfrmCadUsuario_usuarioAtivo.CheckedChanged += new System.EventHandler(this.chkboxfrmCadUsuario_usuarioAtivo_CheckedChanged);
            // 
            // lbFrmCadUsuario_tipoPerfil
            // 
            this.lbFrmCadUsuario_tipoPerfil.AutoSize = true;
            this.lbFrmCadUsuario_tipoPerfil.Location = new System.Drawing.Point(18, 97);
            this.lbFrmCadUsuario_tipoPerfil.Name = "lbFrmCadUsuario_tipoPerfil";
            this.lbFrmCadUsuario_tipoPerfil.Size = new System.Drawing.Size(36, 13);
            this.lbFrmCadUsuario_tipoPerfil.TabIndex = 9;
            this.lbFrmCadUsuario_tipoPerfil.Text = "Grupo";
            this.lbFrmCadUsuario_tipoPerfil.Click += new System.EventHandler(this.lbFrmCadUsuario_tipoPerfil_Click);
            // 
            // lbFrmAlteraUsuario_loginUsuario
            // 
            this.lbFrmAlteraUsuario_loginUsuario.AutoSize = true;
            this.lbFrmAlteraUsuario_loginUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmAlteraUsuario_loginUsuario.Location = new System.Drawing.Point(18, 56);
            this.lbFrmAlteraUsuario_loginUsuario.Name = "lbFrmAlteraUsuario_loginUsuario";
            this.lbFrmAlteraUsuario_loginUsuario.Size = new System.Drawing.Size(33, 13);
            this.lbFrmAlteraUsuario_loginUsuario.TabIndex = 4;
            this.lbFrmAlteraUsuario_loginUsuario.Text = "Login";
            this.lbFrmAlteraUsuario_loginUsuario.Click += new System.EventHandler(this.lbFrmCadUsuario_loginUsuario_Click);
            // 
            // lbFrmAlteraUsuario_nomeUsuario
            // 
            this.lbFrmAlteraUsuario_nomeUsuario.AutoSize = true;
            this.lbFrmAlteraUsuario_nomeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmAlteraUsuario_nomeUsuario.Location = new System.Drawing.Point(18, 23);
            this.lbFrmAlteraUsuario_nomeUsuario.Name = "lbFrmAlteraUsuario_nomeUsuario";
            this.lbFrmAlteraUsuario_nomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.lbFrmAlteraUsuario_nomeUsuario.TabIndex = 3;
            this.lbFrmAlteraUsuario_nomeUsuario.Text = "Nome do Usuario";
            this.lbFrmAlteraUsuario_nomeUsuario.Click += new System.EventHandler(this.lbFrmCadUsuario_nomeUsuario_Click);
            // 
            // txtFrmAlteraUsuario_loginUsuario
            // 
            this.txtFrmAlteraUsuario_loginUsuario.Location = new System.Drawing.Point(122, 53);
            this.txtFrmAlteraUsuario_loginUsuario.Name = "txtFrmAlteraUsuario_loginUsuario";
            this.txtFrmAlteraUsuario_loginUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtFrmAlteraUsuario_loginUsuario.TabIndex = 1;
            this.txtFrmAlteraUsuario_loginUsuario.TextChanged += new System.EventHandler(this.txtFrmCadUsuario_loginUsuario_TextChanged);
            // 
            // txtFrmAlteraUsuario_nomeUsuario
            // 
            this.txtFrmAlteraUsuario_nomeUsuario.Location = new System.Drawing.Point(122, 20);
            this.txtFrmAlteraUsuario_nomeUsuario.Name = "txtFrmAlteraUsuario_nomeUsuario";
            this.txtFrmAlteraUsuario_nomeUsuario.Size = new System.Drawing.Size(413, 20);
            this.txtFrmAlteraUsuario_nomeUsuario.TabIndex = 0;
            this.txtFrmAlteraUsuario_nomeUsuario.TextChanged += new System.EventHandler(this.txtFrmCadUsuario_nomeUsuario_TextChanged);
            // 
            // btnFrmAlteraUsuario_resetSenha
            // 
            this.btnFrmAlteraUsuario_resetSenha.Location = new System.Drawing.Point(109, 384);
            this.btnFrmAlteraUsuario_resetSenha.Name = "btnFrmAlteraUsuario_resetSenha";
            this.btnFrmAlteraUsuario_resetSenha.Size = new System.Drawing.Size(113, 23);
            this.btnFrmAlteraUsuario_resetSenha.TabIndex = 16;
            this.btnFrmAlteraUsuario_resetSenha.Text = "Reset de Senha";
            this.btnFrmAlteraUsuario_resetSenha.UseVisualStyleBackColor = true;
            // 
            // FrmTelaAlteraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 481);
            this.Controls.Add(this.btnFrmAlteraUsuario_resetSenha);
            this.Controls.Add(this.pnCadUsuario);
            this.Controls.Add(this.dataGridView_AlteraUsuario);
            this.Controls.Add(this.btnFrmAlteraUsuario_confirmaAlteracao);
            this.Controls.Add(this.btnFrmAlteraUsuario_BuscarUsuario);
            this.Controls.Add(this.txtFrmAlteraUsuario_buscarNomeUsuario);
            this.Controls.Add(this.lbFrmAlteraUsuario_buscarNomeUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmTelaAlteraUsuario";
            this.Text = "FrmTelaAlteraUsuario";
            this.Load += new System.EventHandler(this.FrmTelaAlteraUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlteraUsuario)).EndInit();
            this.pnCadUsuario.ResumeLayout(false);
            this.pnCadUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmAlteraUsuario_BuscarUsuario;
        private System.Windows.Forms.TextBox txtFrmAlteraUsuario_buscarNomeUsuario;
        private System.Windows.Forms.Label lbFrmAlteraUsuario_buscarNomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrmAlteraUsuario_confirmaAlteracao;
        private System.Windows.Forms.DataGridView dataGridView_AlteraUsuario;
        private System.Windows.Forms.Panel pnCadUsuario;
        private System.Windows.Forms.CheckBox chkboxfrmCadUsuario_usuarioAtivo;
        private System.Windows.Forms.Label lbFrmCadUsuario_tipoPerfil;
        private System.Windows.Forms.Label lbFrmAlteraUsuario_loginUsuario;
        private System.Windows.Forms.Label lbFrmAlteraUsuario_nomeUsuario;
        private System.Windows.Forms.TextBox txtFrmAlteraUsuario_loginUsuario;
        private System.Windows.Forms.TextBox txtFrmAlteraUsuario_nomeUsuario;
        private System.Windows.Forms.ComboBox comboBoxAlteraUsuario_tipoPerfil;
        private System.Windows.Forms.Button btnFrmAlteraUsuario_resetSenha;
    }
}