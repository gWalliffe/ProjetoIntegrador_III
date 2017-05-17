namespace FormularioPrincipal
{
    partial class FrmTelaCadProduto
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
            System.Windows.Forms.Button btnFrmCadProduto_limpar;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCadProduto = new System.Windows.Forms.PictureBox();
            this.comboBoxCadProduto_VisualizarCategoria = new System.Windows.Forms.ComboBox();
            this.lbFrmCadProduto_DescontoPromocao = new System.Windows.Forms.Label();
            this.txtFrmCadProduto_DescontoPromocao = new System.Windows.Forms.TextBox();
            this.txtFrmCadProduto_descProduto = new System.Windows.Forms.RichTextBox();
            this.rdb_ativoProduto = new System.Windows.Forms.RadioButton();
            this.lbFrmCadProduto_qtdMinProduto = new System.Windows.Forms.Label();
            this.txtFrmCadProduto_qtdMinProduto = new System.Windows.Forms.TextBox();
            this.lbFrmCadProduto_PrecProduto = new System.Windows.Forms.Label();
            this.txtFrmCadProduto_PrecProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFrmCadProduto_FKidCategoria = new System.Windows.Forms.Label();
            this.lbFrmCadProduto_descProduto = new System.Windows.Forms.Label();
            this.lbFrmCadProduto_nomeProduto = new System.Windows.Forms.Label();
            this.txtFrmCadProduto_nomeProduto = new System.Windows.Forms.TextBox();
            this.btnFrmCadProduto_confirmaCadastro = new System.Windows.Forms.Button();
            this.btnFrmCadProduto_ProcurarImagem = new System.Windows.Forms.Button();
            btnFrmCadProduto_limpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrmCadProduto_limpar
            // 
            btnFrmCadProduto_limpar.Location = new System.Drawing.Point(103, 439);
            btnFrmCadProduto_limpar.Name = "btnFrmCadProduto_limpar";
            btnFrmCadProduto_limpar.Size = new System.Drawing.Size(131, 23);
            btnFrmCadProduto_limpar.TabIndex = 15;
            btnFrmCadProduto_limpar.Text = "Limpar";
            btnFrmCadProduto_limpar.UseVisualStyleBackColor = true;
            btnFrmCadProduto_limpar.Click += new System.EventHandler(this.btnFrmCadCliente_limpar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFrmCadProduto_ProcurarImagem);
            this.panel1.Controls.Add(this.pictureBoxCadProduto);
            this.panel1.Controls.Add(this.comboBoxCadProduto_VisualizarCategoria);
            this.panel1.Controls.Add(this.lbFrmCadProduto_DescontoPromocao);
            this.panel1.Controls.Add(this.txtFrmCadProduto_DescontoPromocao);
            this.panel1.Controls.Add(this.txtFrmCadProduto_descProduto);
            this.panel1.Controls.Add(this.rdb_ativoProduto);
            this.panel1.Controls.Add(this.lbFrmCadProduto_qtdMinProduto);
            this.panel1.Controls.Add(this.txtFrmCadProduto_qtdMinProduto);
            this.panel1.Controls.Add(this.lbFrmCadProduto_PrecProduto);
            this.panel1.Controls.Add(this.txtFrmCadProduto_PrecProduto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbFrmCadProduto_FKidCategoria);
            this.panel1.Controls.Add(this.lbFrmCadProduto_descProduto);
            this.panel1.Controls.Add(this.lbFrmCadProduto_nomeProduto);
            this.panel1.Controls.Add(this.txtFrmCadProduto_nomeProduto);
            this.panel1.Location = new System.Drawing.Point(61, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 393);
            this.panel1.TabIndex = 6;
            // 
            // pictureBoxCadProduto
            // 
            this.pictureBoxCadProduto.Location = new System.Drawing.Point(121, 263);
            this.pictureBoxCadProduto.Name = "pictureBoxCadProduto";
            this.pictureBoxCadProduto.Size = new System.Drawing.Size(226, 111);
            this.pictureBoxCadProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCadProduto.TabIndex = 18;
            this.pictureBoxCadProduto.TabStop = false;
            // 
            // comboBoxCadProduto_VisualizarCategoria
            // 
            this.comboBoxCadProduto_VisualizarCategoria.FormattingEnabled = true;
            this.comboBoxCadProduto_VisualizarCategoria.Location = new System.Drawing.Point(121, 208);
            this.comboBoxCadProduto_VisualizarCategoria.Name = "comboBoxCadProduto_VisualizarCategoria";
            this.comboBoxCadProduto_VisualizarCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCadProduto_VisualizarCategoria.TabIndex = 17;
            this.comboBoxCadProduto_VisualizarCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCadProduto_VisualizarCategoria_SelectedIndexChanged);
            // 
            // lbFrmCadProduto_DescontoPromocao
            // 
            this.lbFrmCadProduto_DescontoPromocao.AutoSize = true;
            this.lbFrmCadProduto_DescontoPromocao.Location = new System.Drawing.Point(305, 170);
            this.lbFrmCadProduto_DescontoPromocao.Name = "lbFrmCadProduto_DescontoPromocao";
            this.lbFrmCadProduto_DescontoPromocao.Size = new System.Drawing.Size(114, 13);
            this.lbFrmCadProduto_DescontoPromocao.TabIndex = 16;
            this.lbFrmCadProduto_DescontoPromocao.Text = "Desconto Promocional";
            // 
            // txtFrmCadProduto_DescontoPromocao
            // 
            this.txtFrmCadProduto_DescontoPromocao.Location = new System.Drawing.Point(425, 167);
            this.txtFrmCadProduto_DescontoPromocao.Name = "txtFrmCadProduto_DescontoPromocao";
            this.txtFrmCadProduto_DescontoPromocao.Size = new System.Drawing.Size(109, 20);
            this.txtFrmCadProduto_DescontoPromocao.TabIndex = 15;
            // 
            // txtFrmCadProduto_descProduto
            // 
            this.txtFrmCadProduto_descProduto.Location = new System.Drawing.Point(121, 106);
            this.txtFrmCadProduto_descProduto.Name = "txtFrmCadProduto_descProduto";
            this.txtFrmCadProduto_descProduto.Size = new System.Drawing.Size(413, 47);
            this.txtFrmCadProduto_descProduto.TabIndex = 14;
            this.txtFrmCadProduto_descProduto.Text = "";
            // 
            // rdb_ativoProduto
            // 
            this.rdb_ativoProduto.AutoSize = true;
            this.rdb_ativoProduto.Location = new System.Drawing.Point(420, 251);
            this.rdb_ativoProduto.Name = "rdb_ativoProduto";
            this.rdb_ativoProduto.Size = new System.Drawing.Size(114, 17);
            this.rdb_ativoProduto.TabIndex = 13;
            this.rdb_ativoProduto.TabStop = true;
            this.rdb_ativoProduto.Text = "Produto disponível";
            this.rdb_ativoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_ativoProduto.UseVisualStyleBackColor = true;
            // 
            // lbFrmCadProduto_qtdMinProduto
            // 
            this.lbFrmCadProduto_qtdMinProduto.AutoSize = true;
            this.lbFrmCadProduto_qtdMinProduto.Location = new System.Drawing.Point(293, 211);
            this.lbFrmCadProduto_qtdMinProduto.Name = "lbFrmCadProduto_qtdMinProduto";
            this.lbFrmCadProduto_qtdMinProduto.Size = new System.Drawing.Size(100, 13);
            this.lbFrmCadProduto_qtdMinProduto.TabIndex = 12;
            this.lbFrmCadProduto_qtdMinProduto.Text = "Quantidade Mínima";
            this.lbFrmCadProduto_qtdMinProduto.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFrmCadProduto_qtdMinProduto
            // 
            this.txtFrmCadProduto_qtdMinProduto.Location = new System.Drawing.Point(399, 208);
            this.txtFrmCadProduto_qtdMinProduto.Name = "txtFrmCadProduto_qtdMinProduto";
            this.txtFrmCadProduto_qtdMinProduto.Size = new System.Drawing.Size(135, 20);
            this.txtFrmCadProduto_qtdMinProduto.TabIndex = 11;
            // 
            // lbFrmCadProduto_PrecProduto
            // 
            this.lbFrmCadProduto_PrecProduto.AutoSize = true;
            this.lbFrmCadProduto_PrecProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmCadProduto_PrecProduto.Location = new System.Drawing.Point(20, 170);
            this.lbFrmCadProduto_PrecProduto.Name = "lbFrmCadProduto_PrecProduto";
            this.lbFrmCadProduto_PrecProduto.Size = new System.Drawing.Size(31, 13);
            this.lbFrmCadProduto_PrecProduto.TabIndex = 10;
            this.lbFrmCadProduto_PrecProduto.Text = "Valor";
            // 
            // txtFrmCadProduto_PrecProduto
            // 
            this.txtFrmCadProduto_PrecProduto.Location = new System.Drawing.Point(121, 167);
            this.txtFrmCadProduto_PrecProduto.Name = "txtFrmCadProduto_PrecProduto";
            this.txtFrmCadProduto_PrecProduto.Size = new System.Drawing.Size(121, 20);
            this.txtFrmCadProduto_PrecProduto.TabIndex = 9;
            this.txtFrmCadProduto_PrecProduto.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(224, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cadastro de Produto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFrmCadProduto_FKidCategoria
            // 
            this.lbFrmCadProduto_FKidCategoria.AutoSize = true;
            this.lbFrmCadProduto_FKidCategoria.Location = new System.Drawing.Point(21, 211);
            this.lbFrmCadProduto_FKidCategoria.Name = "lbFrmCadProduto_FKidCategoria";
            this.lbFrmCadProduto_FKidCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbFrmCadProduto_FKidCategoria.TabIndex = 5;
            this.lbFrmCadProduto_FKidCategoria.Text = "Categoria";
            // 
            // lbFrmCadProduto_descProduto
            // 
            this.lbFrmCadProduto_descProduto.AutoSize = true;
            this.lbFrmCadProduto_descProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmCadProduto_descProduto.Location = new System.Drawing.Point(21, 106);
            this.lbFrmCadProduto_descProduto.Name = "lbFrmCadProduto_descProduto";
            this.lbFrmCadProduto_descProduto.Size = new System.Drawing.Size(55, 13);
            this.lbFrmCadProduto_descProduto.TabIndex = 4;
            this.lbFrmCadProduto_descProduto.Text = "Descrição";
            // 
            // lbFrmCadProduto_nomeProduto
            // 
            this.lbFrmCadProduto_nomeProduto.AutoSize = true;
            this.lbFrmCadProduto_nomeProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFrmCadProduto_nomeProduto.Location = new System.Drawing.Point(20, 69);
            this.lbFrmCadProduto_nomeProduto.Name = "lbFrmCadProduto_nomeProduto";
            this.lbFrmCadProduto_nomeProduto.Size = new System.Drawing.Size(75, 13);
            this.lbFrmCadProduto_nomeProduto.TabIndex = 3;
            this.lbFrmCadProduto_nomeProduto.Text = "Nome Produto";
            // 
            // txtFrmCadProduto_nomeProduto
            // 
            this.txtFrmCadProduto_nomeProduto.Location = new System.Drawing.Point(121, 66);
            this.txtFrmCadProduto_nomeProduto.Name = "txtFrmCadProduto_nomeProduto";
            this.txtFrmCadProduto_nomeProduto.Size = new System.Drawing.Size(413, 20);
            this.txtFrmCadProduto_nomeProduto.TabIndex = 0;
            this.txtFrmCadProduto_nomeProduto.TextChanged += new System.EventHandler(this.txt_NomeCadastroProduto_TextChanged);
            // 
            // btnFrmCadProduto_confirmaCadastro
            // 
            this.btnFrmCadProduto_confirmaCadastro.Location = new System.Drawing.Point(482, 439);
            this.btnFrmCadProduto_confirmaCadastro.Name = "btnFrmCadProduto_confirmaCadastro";
            this.btnFrmCadProduto_confirmaCadastro.Size = new System.Drawing.Size(131, 23);
            this.btnFrmCadProduto_confirmaCadastro.TabIndex = 14;
            this.btnFrmCadProduto_confirmaCadastro.Text = "Confirmar Cadastro";
            this.btnFrmCadProduto_confirmaCadastro.UseVisualStyleBackColor = true;
            this.btnFrmCadProduto_confirmaCadastro.Click += new System.EventHandler(this.btnFrmCadCliente_confirmaCadastro_Click);
            // 
            // btnFrmCadProduto_ProcurarImagem
            // 
            this.btnFrmCadProduto_ProcurarImagem.Location = new System.Drawing.Point(23, 263);
            this.btnFrmCadProduto_ProcurarImagem.Name = "btnFrmCadProduto_ProcurarImagem";
            this.btnFrmCadProduto_ProcurarImagem.Size = new System.Drawing.Size(72, 31);
            this.btnFrmCadProduto_ProcurarImagem.TabIndex = 19;
            this.btnFrmCadProduto_ProcurarImagem.Text = "button1";
            this.btnFrmCadProduto_ProcurarImagem.UseVisualStyleBackColor = true;
            this.btnFrmCadProduto_ProcurarImagem.Click += new System.EventHandler(this.btnFrmCadProduto_ProcurarImagem_Click);
            // 
            // FrmTelaCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(btnFrmCadProduto_limpar);
            this.Controls.Add(this.btnFrmCadProduto_confirmaCadastro);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTelaCadProduto";
            this.Text = "FrmTelaCadProduto";
            this.Load += new System.EventHandler(this.FrmTelaCadProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_ativoProduto;
        private System.Windows.Forms.Label lbFrmCadProduto_qtdMinProduto;
        private System.Windows.Forms.TextBox txtFrmCadProduto_qtdMinProduto;
        private System.Windows.Forms.Label lbFrmCadProduto_PrecProduto;
        private System.Windows.Forms.TextBox txtFrmCadProduto_PrecProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFrmCadProduto_FKidCategoria;
        private System.Windows.Forms.Label lbFrmCadProduto_descProduto;
        private System.Windows.Forms.Label lbFrmCadProduto_nomeProduto;
        private System.Windows.Forms.TextBox txtFrmCadProduto_nomeProduto;
        private System.Windows.Forms.RichTextBox txtFrmCadProduto_descProduto;
        private System.Windows.Forms.Label lbFrmCadProduto_DescontoPromocao;
        private System.Windows.Forms.TextBox txtFrmCadProduto_DescontoPromocao;
        private System.Windows.Forms.PictureBox pictureBoxCadProduto;
        private System.Windows.Forms.ComboBox comboBoxCadProduto_VisualizarCategoria;
        private System.Windows.Forms.Button btnFrmCadProduto_confirmaCadastro;
        private System.Windows.Forms.Button btnFrmCadProduto_ProcurarImagem;
    }
}