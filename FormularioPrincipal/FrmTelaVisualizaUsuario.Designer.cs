namespace FormularioPrincipal
{
    partial class FrmTelaVisualizaUsuario
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
            this.dataGridView_VisualizaUsuario = new System.Windows.Forms.DataGridView();
            this.btnFrmVisualizaUsuario_BuscarUsuario = new System.Windows.Forms.Button();
            this.txtFrmVisualizaUsuario_nomeUsuario = new System.Windows.Forms.TextBox();
            this.lbFrmVisualizaUsuario_nomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVisualizaUsuario_tipoPerfil = new System.Windows.Forms.ComboBox();
            this.chkboxfrmVisualizaUsuario_usuarioAtivo = new System.Windows.Forms.CheckBox();
            this.lbFrmVisualizaUsuario_tipoPerfil = new System.Windows.Forms.Label();
            this.lbFrmVisualizaUsuario_loginUsuario = new System.Windows.Forms.Label();
            this.lbFrmAlteraUsuario_nomeUsuario2 = new System.Windows.Forms.Label();
            this.txtFrmVisualizaUsuario_loginUsuario = new System.Windows.Forms.TextBox();
            this.txtFrmVisualizaUsuario_nomeUsuario2 = new System.Windows.Forms.TextBox();
            this.btnTelaVisualizaUsuario_deletarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VisualizaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_VisualizaUsuario
            // 
            this.dataGridView_VisualizaUsuario.AllowUserToAddRows = false;
            this.dataGridView_VisualizaUsuario.AllowUserToDeleteRows = false;
            this.dataGridView_VisualizaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VisualizaUsuario.Location = new System.Drawing.Point(58, 101);
            this.dataGridView_VisualizaUsuario.Name = "dataGridView_VisualizaUsuario";
            this.dataGridView_VisualizaUsuario.ReadOnly = true;
            this.dataGridView_VisualizaUsuario.Size = new System.Drawing.Size(638, 143);
            this.dataGridView_VisualizaUsuario.TabIndex = 13;
            this.dataGridView_VisualizaUsuario.SelectionChanged += new System.EventHandler(this.dataGridView_VisualizaUsuario_SelectionChanged);
            // 
            // btnFrmVisualizaUsuario_BuscarUsuario
            // 
            this.btnFrmVisualizaUsuario_BuscarUsuario.Location = new System.Drawing.Point(434, 57);
            this.btnFrmVisualizaUsuario_BuscarUsuario.Name = "btnFrmVisualizaUsuario_BuscarUsuario";
            this.btnFrmVisualizaUsuario_BuscarUsuario.Size = new System.Drawing.Size(71, 25);
            this.btnFrmVisualizaUsuario_BuscarUsuario.TabIndex = 12;
            this.btnFrmVisualizaUsuario_BuscarUsuario.Text = "Buscar";
            this.btnFrmVisualizaUsuario_BuscarUsuario.UseVisualStyleBackColor = true;
            this.btnFrmVisualizaUsuario_BuscarUsuario.Click += new System.EventHandler(this.btnFrmVisualizaUsuario_BuscarUsuario_Click);
            // 
            // txtFrmVisualizaUsuario_nomeUsuario
            // 
            this.txtFrmVisualizaUsuario_nomeUsuario.Location = new System.Drawing.Point(272, 60);
            this.txtFrmVisualizaUsuario_nomeUsuario.Name = "txtFrmVisualizaUsuario_nomeUsuario";
            this.txtFrmVisualizaUsuario_nomeUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtFrmVisualizaUsuario_nomeUsuario.TabIndex = 11;
            // 
            // lbFrmVisualizaUsuario_nomeUsuario
            // 
            this.lbFrmVisualizaUsuario_nomeUsuario.AutoSize = true;
            this.lbFrmVisualizaUsuario_nomeUsuario.Location = new System.Drawing.Point(142, 63);
            this.lbFrmVisualizaUsuario_nomeUsuario.Name = "lbFrmVisualizaUsuario_nomeUsuario";
            this.lbFrmVisualizaUsuario_nomeUsuario.Size = new System.Drawing.Size(126, 13);
            this.lbFrmVisualizaUsuario_nomeUsuario.TabIndex = 10;
            this.lbFrmVisualizaUsuario_nomeUsuario.Text = "Digite o Nome do usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Visualizar Usuario";
            // 
            // comboBoxVisualizaUsuario_tipoPerfil
            // 
            this.comboBoxVisualizaUsuario_tipoPerfil.Enabled = false;
            this.comboBoxVisualizaUsuario_tipoPerfil.FormattingEnabled = true;
            this.comboBoxVisualizaUsuario_tipoPerfil.Items.AddRange(new object[] {
            "A",
            "E"});
            this.comboBoxVisualizaUsuario_tipoPerfil.Location = new System.Drawing.Point(237, 338);
            this.comboBoxVisualizaUsuario_tipoPerfil.Name = "comboBoxVisualizaUsuario_tipoPerfil";
            this.comboBoxVisualizaUsuario_tipoPerfil.Size = new System.Drawing.Size(37, 21);
            this.comboBoxVisualizaUsuario_tipoPerfil.TabIndex = 20;
            // 
            // chkboxfrmVisualizaUsuario_usuarioAtivo
            // 
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.AutoSize = true;
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.Enabled = false;
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.Location = new System.Drawing.Point(468, 300);
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.Name = "chkboxfrmVisualizaUsuario_usuarioAtivo";
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.Size = new System.Drawing.Size(89, 17);
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.TabIndex = 19;
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.Text = "Usuario Ativo";
            this.chkboxfrmVisualizaUsuario_usuarioAtivo.UseVisualStyleBackColor = true;
            // 
            // lbFrmVisualizaUsuario_tipoPerfil
            // 
            this.lbFrmVisualizaUsuario_tipoPerfil.AutoSize = true;
            this.lbFrmVisualizaUsuario_tipoPerfil.Location = new System.Drawing.Point(133, 341);
            this.lbFrmVisualizaUsuario_tipoPerfil.Name = "lbFrmVisualizaUsuario_tipoPerfil";
            this.lbFrmVisualizaUsuario_tipoPerfil.Size = new System.Drawing.Size(36, 13);
            this.lbFrmVisualizaUsuario_tipoPerfil.TabIndex = 18;
            this.lbFrmVisualizaUsuario_tipoPerfil.Text = "Grupo";
            // 
            // lbFrmVisualizaUsuario_loginUsuario
            // 
            this.lbFrmVisualizaUsuario_loginUsuario.AutoSize = true;
            this.lbFrmVisualizaUsuario_loginUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmVisualizaUsuario_loginUsuario.Location = new System.Drawing.Point(133, 300);
            this.lbFrmVisualizaUsuario_loginUsuario.Name = "lbFrmVisualizaUsuario_loginUsuario";
            this.lbFrmVisualizaUsuario_loginUsuario.Size = new System.Drawing.Size(33, 13);
            this.lbFrmVisualizaUsuario_loginUsuario.TabIndex = 17;
            this.lbFrmVisualizaUsuario_loginUsuario.Text = "Login";
            // 
            // lbFrmAlteraUsuario_nomeUsuario2
            // 
            this.lbFrmAlteraUsuario_nomeUsuario2.AutoSize = true;
            this.lbFrmAlteraUsuario_nomeUsuario2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmAlteraUsuario_nomeUsuario2.Location = new System.Drawing.Point(133, 267);
            this.lbFrmAlteraUsuario_nomeUsuario2.Name = "lbFrmAlteraUsuario_nomeUsuario2";
            this.lbFrmAlteraUsuario_nomeUsuario2.Size = new System.Drawing.Size(89, 13);
            this.lbFrmAlteraUsuario_nomeUsuario2.TabIndex = 16;
            this.lbFrmAlteraUsuario_nomeUsuario2.Text = "Nome do Usuario";
            // 
            // txtFrmVisualizaUsuario_loginUsuario
            // 
            this.txtFrmVisualizaUsuario_loginUsuario.Enabled = false;
            this.txtFrmVisualizaUsuario_loginUsuario.Location = new System.Drawing.Point(237, 297);
            this.txtFrmVisualizaUsuario_loginUsuario.Name = "txtFrmVisualizaUsuario_loginUsuario";
            this.txtFrmVisualizaUsuario_loginUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtFrmVisualizaUsuario_loginUsuario.TabIndex = 15;
            // 
            // txtFrmVisualizaUsuario_nomeUsuario2
            // 
            this.txtFrmVisualizaUsuario_nomeUsuario2.Enabled = false;
            this.txtFrmVisualizaUsuario_nomeUsuario2.Location = new System.Drawing.Point(237, 264);
            this.txtFrmVisualizaUsuario_nomeUsuario2.Name = "txtFrmVisualizaUsuario_nomeUsuario2";
            this.txtFrmVisualizaUsuario_nomeUsuario2.Size = new System.Drawing.Size(413, 20);
            this.txtFrmVisualizaUsuario_nomeUsuario2.TabIndex = 14;
            // 
            // btnTelaVisualizaUsuario_deletarUsuario
            // 
            this.btnTelaVisualizaUsuario_deletarUsuario.Location = new System.Drawing.Point(605, 373);
            this.btnTelaVisualizaUsuario_deletarUsuario.Name = "btnTelaVisualizaUsuario_deletarUsuario";
            this.btnTelaVisualizaUsuario_deletarUsuario.Size = new System.Drawing.Size(91, 38);
            this.btnTelaVisualizaUsuario_deletarUsuario.TabIndex = 21;
            this.btnTelaVisualizaUsuario_deletarUsuario.Text = "Deletar Usuario Selecionado";
            this.btnTelaVisualizaUsuario_deletarUsuario.UseVisualStyleBackColor = true;
            this.btnTelaVisualizaUsuario_deletarUsuario.Click += new System.EventHandler(this.btnTelaVisualizaUsuario_deletarUsuario_Click);
            // 
            // FrmTelaVisualizaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 505);
            this.Controls.Add(this.btnTelaVisualizaUsuario_deletarUsuario);
            this.Controls.Add(this.comboBoxVisualizaUsuario_tipoPerfil);
            this.Controls.Add(this.chkboxfrmVisualizaUsuario_usuarioAtivo);
            this.Controls.Add(this.lbFrmVisualizaUsuario_tipoPerfil);
            this.Controls.Add(this.lbFrmVisualizaUsuario_loginUsuario);
            this.Controls.Add(this.lbFrmAlteraUsuario_nomeUsuario2);
            this.Controls.Add(this.txtFrmVisualizaUsuario_loginUsuario);
            this.Controls.Add(this.txtFrmVisualizaUsuario_nomeUsuario2);
            this.Controls.Add(this.dataGridView_VisualizaUsuario);
            this.Controls.Add(this.btnFrmVisualizaUsuario_BuscarUsuario);
            this.Controls.Add(this.txtFrmVisualizaUsuario_nomeUsuario);
            this.Controls.Add(this.lbFrmVisualizaUsuario_nomeUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmTelaVisualizaUsuario";
            this.Text = "FrmTelaVisualizarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VisualizaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_VisualizaUsuario;
        private System.Windows.Forms.Button btnFrmVisualizaUsuario_BuscarUsuario;
        private System.Windows.Forms.TextBox txtFrmVisualizaUsuario_nomeUsuario;
        private System.Windows.Forms.Label lbFrmVisualizaUsuario_nomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVisualizaUsuario_tipoPerfil;
        private System.Windows.Forms.CheckBox chkboxfrmVisualizaUsuario_usuarioAtivo;
        private System.Windows.Forms.Label lbFrmVisualizaUsuario_tipoPerfil;
        private System.Windows.Forms.Label lbFrmVisualizaUsuario_loginUsuario;
        private System.Windows.Forms.Label lbFrmAlteraUsuario_nomeUsuario2;
        private System.Windows.Forms.TextBox txtFrmVisualizaUsuario_loginUsuario;
        private System.Windows.Forms.TextBox txtFrmVisualizaUsuario_nomeUsuario2;
        private System.Windows.Forms.Button btnTelaVisualizaUsuario_deletarUsuario;
    }
}