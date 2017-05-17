namespace FormularioPrincipal
{
    partial class FrmTelaAlteraCategoria
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
            this.btnFrmAlteraCategoria_BuscarCategoria = new System.Windows.Forms.Button();
            this.txtFrmAlteraCategoria_idCategoria = new System.Windows.Forms.TextBox();
            this.lbFrmAlteraCategoria_idCategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFrmAlteraCategoria_confirmaAlteracao = new System.Windows.Forms.Button();
            this.txtFrmAlteraCategoria_descCategoria = new System.Windows.Forms.RichTextBox();
            this.lbFrmAlteraCategoria_descCategoria = new System.Windows.Forms.Label();
            this.txtFrmAlteraCategoria_nomeCategoria = new System.Windows.Forms.TextBox();
            this.lbFrmAlteraCategoria_nomeCategoria = new System.Windows.Forms.Label();
            this.dataGridView_AlteraCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlteraCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrmAlteraCategoria_BuscarCategoria
            // 
            this.btnFrmAlteraCategoria_BuscarCategoria.Location = new System.Drawing.Point(446, 61);
            this.btnFrmAlteraCategoria_BuscarCategoria.Name = "btnFrmAlteraCategoria_BuscarCategoria";
            this.btnFrmAlteraCategoria_BuscarCategoria.Size = new System.Drawing.Size(71, 25);
            this.btnFrmAlteraCategoria_BuscarCategoria.TabIndex = 9;
            this.btnFrmAlteraCategoria_BuscarCategoria.Text = "Buscar";
            this.btnFrmAlteraCategoria_BuscarCategoria.UseVisualStyleBackColor = true;
            this.btnFrmAlteraCategoria_BuscarCategoria.Click += new System.EventHandler(this.btnFrmAlteraCategoria_BuscarCategoria_Click);
            // 
            // txtFrmAlteraCategoria_idCategoria
            // 
            this.txtFrmAlteraCategoria_idCategoria.Location = new System.Drawing.Point(268, 64);
            this.txtFrmAlteraCategoria_idCategoria.Name = "txtFrmAlteraCategoria_idCategoria";
            this.txtFrmAlteraCategoria_idCategoria.Size = new System.Drawing.Size(159, 20);
            this.txtFrmAlteraCategoria_idCategoria.TabIndex = 8;
            this.txtFrmAlteraCategoria_idCategoria.TextChanged += new System.EventHandler(this.txtFrmAlteraCategoria_nomeCategoria_TextChanged);
            // 
            // lbFrmAlteraCategoria_idCategoria
            // 
            this.lbFrmAlteraCategoria_idCategoria.AutoSize = true;
            this.lbFrmAlteraCategoria_idCategoria.Location = new System.Drawing.Point(148, 67);
            this.lbFrmAlteraCategoria_idCategoria.Name = "lbFrmAlteraCategoria_idCategoria";
            this.lbFrmAlteraCategoria_idCategoria.Size = new System.Drawing.Size(103, 13);
            this.lbFrmAlteraCategoria_idCategoria.TabIndex = 7;
            this.lbFrmAlteraCategoria_idCategoria.Text = "Codigo da Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(306, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alterar Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFrmAlteraCategoria_confirmaAlteracao
            // 
            this.btnFrmAlteraCategoria_confirmaAlteracao.Location = new System.Drawing.Point(386, 350);
            this.btnFrmAlteraCategoria_confirmaAlteracao.Name = "btnFrmAlteraCategoria_confirmaAlteracao";
            this.btnFrmAlteraCategoria_confirmaAlteracao.Size = new System.Drawing.Size(131, 23);
            this.btnFrmAlteraCategoria_confirmaAlteracao.TabIndex = 14;
            this.btnFrmAlteraCategoria_confirmaAlteracao.Text = "Confirmar Alteração";
            this.btnFrmAlteraCategoria_confirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnFrmAlteraCategoria_confirmaAlteracao.Click += new System.EventHandler(this.btnFrmAlteraCategoria_confirmaAlteracao_Click);
            // 
            // txtFrmAlteraCategoria_descCategoria
            // 
            this.txtFrmAlteraCategoria_descCategoria.Location = new System.Drawing.Point(215, 284);
            this.txtFrmAlteraCategoria_descCategoria.Name = "txtFrmAlteraCategoria_descCategoria";
            this.txtFrmAlteraCategoria_descCategoria.Size = new System.Drawing.Size(325, 45);
            this.txtFrmAlteraCategoria_descCategoria.TabIndex = 18;
            this.txtFrmAlteraCategoria_descCategoria.Text = "";
            // 
            // lbFrmAlteraCategoria_descCategoria
            // 
            this.lbFrmAlteraCategoria_descCategoria.AutoSize = true;
            this.lbFrmAlteraCategoria_descCategoria.Location = new System.Drawing.Point(148, 287);
            this.lbFrmAlteraCategoria_descCategoria.Name = "lbFrmAlteraCategoria_descCategoria";
            this.lbFrmAlteraCategoria_descCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbFrmAlteraCategoria_descCategoria.TabIndex = 17;
            this.lbFrmAlteraCategoria_descCategoria.Text = "Descrição";
            // 
            // txtFrmAlteraCategoria_nomeCategoria
            // 
            this.txtFrmAlteraCategoria_nomeCategoria.Location = new System.Drawing.Point(215, 246);
            this.txtFrmAlteraCategoria_nomeCategoria.Name = "txtFrmAlteraCategoria_nomeCategoria";
            this.txtFrmAlteraCategoria_nomeCategoria.Size = new System.Drawing.Size(325, 20);
            this.txtFrmAlteraCategoria_nomeCategoria.TabIndex = 16;
            // 
            // lbFrmAlteraCategoria_nomeCategoria
            // 
            this.lbFrmAlteraCategoria_nomeCategoria.AutoSize = true;
            this.lbFrmAlteraCategoria_nomeCategoria.Location = new System.Drawing.Point(148, 249);
            this.lbFrmAlteraCategoria_nomeCategoria.Name = "lbFrmAlteraCategoria_nomeCategoria";
            this.lbFrmAlteraCategoria_nomeCategoria.Size = new System.Drawing.Size(35, 13);
            this.lbFrmAlteraCategoria_nomeCategoria.TabIndex = 15;
            this.lbFrmAlteraCategoria_nomeCategoria.Text = "Nome";
            // 
            // dataGridView_AlteraCategoria
            // 
            this.dataGridView_AlteraCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AlteraCategoria.Location = new System.Drawing.Point(139, 109);
            this.dataGridView_AlteraCategoria.Name = "dataGridView_AlteraCategoria";
            this.dataGridView_AlteraCategoria.Size = new System.Drawing.Size(411, 115);
            this.dataGridView_AlteraCategoria.TabIndex = 19;
            this.dataGridView_AlteraCategoria.SelectionChanged += new System.EventHandler(this.dataGridView_AlteraCategoria_SelectionChanged);
            // 
            // FrmTelaAlteraCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 477);
            this.Controls.Add(this.dataGridView_AlteraCategoria);
            this.Controls.Add(this.txtFrmAlteraCategoria_descCategoria);
            this.Controls.Add(this.lbFrmAlteraCategoria_descCategoria);
            this.Controls.Add(this.txtFrmAlteraCategoria_nomeCategoria);
            this.Controls.Add(this.lbFrmAlteraCategoria_nomeCategoria);
            this.Controls.Add(this.btnFrmAlteraCategoria_BuscarCategoria);
            this.Controls.Add(this.btnFrmAlteraCategoria_confirmaAlteracao);
            this.Controls.Add(this.txtFrmAlteraCategoria_idCategoria);
            this.Controls.Add(this.lbFrmAlteraCategoria_idCategoria);
            this.Controls.Add(this.label3);
            this.Name = "FrmTelaAlteraCategoria";
            this.Text = "FrmTelaAlteraCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlteraCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFrmAlteraCategoria_idCategoria;
        private System.Windows.Forms.Label lbFrmAlteraCategoria_idCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFrmAlteraCategoria_BuscarCategoria;
        private System.Windows.Forms.Button btnFrmAlteraCategoria_confirmaAlteracao;
        private System.Windows.Forms.RichTextBox txtFrmAlteraCategoria_descCategoria;
        private System.Windows.Forms.Label lbFrmAlteraCategoria_descCategoria;
        private System.Windows.Forms.TextBox txtFrmAlteraCategoria_nomeCategoria;
        private System.Windows.Forms.Label lbFrmAlteraCategoria_nomeCategoria;
        private System.Windows.Forms.DataGridView dataGridView_AlteraCategoria;
    }
}