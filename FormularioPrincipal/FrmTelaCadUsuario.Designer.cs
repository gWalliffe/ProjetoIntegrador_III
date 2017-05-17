namespace FormularioPrincipal
{
    partial class FrmTelaCadUsuario
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
            System.Windows.Forms.Button btnFrmCadUsuario_limpar;
            this.pnCadUsuario = new System.Windows.Forms.Panel();
            this.comboBoxCadUsuario_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.chkboxfrmCadUsuario_usuarioAtivo = new System.Windows.Forms.CheckBox();
            this.lbFrmCadUsuario_tipoPerfil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFrmCadUsuario_senhaUsuario = new System.Windows.Forms.Label();
            this.lbFrmCadUsuario_loginUsuario = new System.Windows.Forms.Label();
            this.lbFrmCadUsuario_nomeUsuario = new System.Windows.Forms.Label();
            this.txtFrmCadUsuario_senhaUsuario = new System.Windows.Forms.TextBox();
            this.txtFrmCadUsuario_loginUsuario = new System.Windows.Forms.TextBox();
            this.txtFrmCadUsuario_nomeUsuario = new System.Windows.Forms.TextBox();
            this.btnFrmCadUsuario_confirmaCadastro = new System.Windows.Forms.Button();
            btnFrmCadUsuario_limpar = new System.Windows.Forms.Button();
            this.pnCadUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrmCadUsuario_limpar
            // 
            btnFrmCadUsuario_limpar.Location = new System.Drawing.Point(85, 322);
            btnFrmCadUsuario_limpar.Name = "btnFrmCadUsuario_limpar";
            btnFrmCadUsuario_limpar.Size = new System.Drawing.Size(131, 23);
            btnFrmCadUsuario_limpar.TabIndex = 13;
            btnFrmCadUsuario_limpar.Text = "Limpar";
            btnFrmCadUsuario_limpar.UseVisualStyleBackColor = true;
            btnFrmCadUsuario_limpar.Click += new System.EventHandler(this.btnFrmCadCliente_limpar_Click);
            // 
            // pnCadUsuario
            // 
            this.pnCadUsuario.Controls.Add(this.comboBoxCadUsuario_tipoUsuario);
            this.pnCadUsuario.Controls.Add(this.chkboxfrmCadUsuario_usuarioAtivo);
            this.pnCadUsuario.Controls.Add(this.lbFrmCadUsuario_tipoPerfil);
            this.pnCadUsuario.Controls.Add(this.label3);
            this.pnCadUsuario.Controls.Add(this.lbFrmCadUsuario_senhaUsuario);
            this.pnCadUsuario.Controls.Add(this.lbFrmCadUsuario_loginUsuario);
            this.pnCadUsuario.Controls.Add(this.lbFrmCadUsuario_nomeUsuario);
            this.pnCadUsuario.Controls.Add(this.txtFrmCadUsuario_senhaUsuario);
            this.pnCadUsuario.Controls.Add(this.txtFrmCadUsuario_loginUsuario);
            this.pnCadUsuario.Controls.Add(this.txtFrmCadUsuario_nomeUsuario);
            this.pnCadUsuario.Location = new System.Drawing.Point(85, 24);
            this.pnCadUsuario.Name = "pnCadUsuario";
            this.pnCadUsuario.Size = new System.Drawing.Size(595, 277);
            this.pnCadUsuario.TabIndex = 5;
            // 
            // comboBoxCadUsuario_tipoUsuario
            // 
            this.comboBoxCadUsuario_tipoUsuario.FormattingEnabled = true;
            this.comboBoxCadUsuario_tipoUsuario.Items.AddRange(new object[] {
            "A",
            "E"});
            this.comboBoxCadUsuario_tipoUsuario.Location = new System.Drawing.Point(111, 186);
            this.comboBoxCadUsuario_tipoUsuario.Name = "comboBoxCadUsuario_tipoUsuario";
            this.comboBoxCadUsuario_tipoUsuario.Size = new System.Drawing.Size(31, 21);
            this.comboBoxCadUsuario_tipoUsuario.TabIndex = 12;
            this.comboBoxCadUsuario_tipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipoUsuario_SelectedIndexChanged);
            // 
            // chkboxfrmCadUsuario_usuarioAtivo
            // 
            this.chkboxfrmCadUsuario_usuarioAtivo.AutoSize = true;
            this.chkboxfrmCadUsuario_usuarioAtivo.Location = new System.Drawing.Point(326, 102);
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
            this.lbFrmCadUsuario_tipoPerfil.Location = new System.Drawing.Point(9, 189);
            this.lbFrmCadUsuario_tipoPerfil.Name = "lbFrmCadUsuario_tipoPerfil";
            this.lbFrmCadUsuario_tipoPerfil.Size = new System.Drawing.Size(28, 13);
            this.lbFrmCadUsuario_tipoPerfil.TabIndex = 9;
            this.lbFrmCadUsuario_tipoPerfil.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(207, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cadastro de Usuário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbFrmCadUsuario_senhaUsuario
            // 
            this.lbFrmCadUsuario_senhaUsuario.AutoSize = true;
            this.lbFrmCadUsuario_senhaUsuario.Location = new System.Drawing.Point(7, 150);
            this.lbFrmCadUsuario_senhaUsuario.Name = "lbFrmCadUsuario_senhaUsuario";
            this.lbFrmCadUsuario_senhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.lbFrmCadUsuario_senhaUsuario.TabIndex = 5;
            this.lbFrmCadUsuario_senhaUsuario.Text = "Senha";
            // 
            // lbFrmCadUsuario_loginUsuario
            // 
            this.lbFrmCadUsuario_loginUsuario.AutoSize = true;
            this.lbFrmCadUsuario_loginUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmCadUsuario_loginUsuario.Location = new System.Drawing.Point(7, 102);
            this.lbFrmCadUsuario_loginUsuario.Name = "lbFrmCadUsuario_loginUsuario";
            this.lbFrmCadUsuario_loginUsuario.Size = new System.Drawing.Size(33, 13);
            this.lbFrmCadUsuario_loginUsuario.TabIndex = 4;
            this.lbFrmCadUsuario_loginUsuario.Text = "Login";
            // 
            // lbFrmCadUsuario_nomeUsuario
            // 
            this.lbFrmCadUsuario_nomeUsuario.AutoSize = true;
            this.lbFrmCadUsuario_nomeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmCadUsuario_nomeUsuario.Location = new System.Drawing.Point(7, 56);
            this.lbFrmCadUsuario_nomeUsuario.Name = "lbFrmCadUsuario_nomeUsuario";
            this.lbFrmCadUsuario_nomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.lbFrmCadUsuario_nomeUsuario.TabIndex = 3;
            this.lbFrmCadUsuario_nomeUsuario.Text = "Nome do Usuario";
            // 
            // txtFrmCadUsuario_senhaUsuario
            // 
            this.txtFrmCadUsuario_senhaUsuario.Location = new System.Drawing.Point(111, 147);
            this.txtFrmCadUsuario_senhaUsuario.Name = "txtFrmCadUsuario_senhaUsuario";
            this.txtFrmCadUsuario_senhaUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtFrmCadUsuario_senhaUsuario.TabIndex = 2;
            // 
            // txtFrmCadUsuario_loginUsuario
            // 
            this.txtFrmCadUsuario_loginUsuario.Location = new System.Drawing.Point(111, 99);
            this.txtFrmCadUsuario_loginUsuario.Name = "txtFrmCadUsuario_loginUsuario";
            this.txtFrmCadUsuario_loginUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtFrmCadUsuario_loginUsuario.TabIndex = 1;
            // 
            // txtFrmCadUsuario_nomeUsuario
            // 
            this.txtFrmCadUsuario_nomeUsuario.Location = new System.Drawing.Point(111, 53);
            this.txtFrmCadUsuario_nomeUsuario.Name = "txtFrmCadUsuario_nomeUsuario";
            this.txtFrmCadUsuario_nomeUsuario.Size = new System.Drawing.Size(413, 20);
            this.txtFrmCadUsuario_nomeUsuario.TabIndex = 0;
            // 
            // btnFrmCadUsuario_confirmaCadastro
            // 
            this.btnFrmCadUsuario_confirmaCadastro.Location = new System.Drawing.Point(549, 322);
            this.btnFrmCadUsuario_confirmaCadastro.Name = "btnFrmCadUsuario_confirmaCadastro";
            this.btnFrmCadUsuario_confirmaCadastro.Size = new System.Drawing.Size(131, 23);
            this.btnFrmCadUsuario_confirmaCadastro.TabIndex = 12;
            this.btnFrmCadUsuario_confirmaCadastro.Text = "Confirmar Cadastro";
            this.btnFrmCadUsuario_confirmaCadastro.UseVisualStyleBackColor = true;
            this.btnFrmCadUsuario_confirmaCadastro.Click += new System.EventHandler(this.btnFrmCadCliente_confirmaCadastro_Click);
            // 
            // FrmTelaCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 438);
            this.Controls.Add(this.pnCadUsuario);
            this.Controls.Add(btnFrmCadUsuario_limpar);
            this.Controls.Add(this.btnFrmCadUsuario_confirmaCadastro);
            this.Name = "FrmTelaCadUsuario";
            this.Text = "FrmTelaCadUsuario";
            this.pnCadUsuario.ResumeLayout(false);
            this.pnCadUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCadUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFrmCadUsuario_senhaUsuario;
        private System.Windows.Forms.Label lbFrmCadUsuario_loginUsuario;
        private System.Windows.Forms.Label lbFrmCadUsuario_nomeUsuario;
        private System.Windows.Forms.TextBox txtFrmCadUsuario_senhaUsuario;
        private System.Windows.Forms.TextBox txtFrmCadUsuario_loginUsuario;
        private System.Windows.Forms.TextBox txtFrmCadUsuario_nomeUsuario;
        private System.Windows.Forms.Label lbFrmCadUsuario_tipoPerfil;
        private System.Windows.Forms.CheckBox chkboxfrmCadUsuario_usuarioAtivo;
        private System.Windows.Forms.Button btnFrmCadUsuario_confirmaCadastro;
        private System.Windows.Forms.ComboBox comboBoxCadUsuario_tipoUsuario;
    }
}