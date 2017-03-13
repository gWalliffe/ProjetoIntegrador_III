namespace PI_III
{
    partial class tela_inicial
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
            this.btn_TelaOrganizacao = new System.Windows.Forms.Button();
            this.btn_TelaCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_telainicial_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TelaOrganizacao
            // 
            this.btn_TelaOrganizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TelaOrganizacao.Image = global::PI_III.Properties.Resources.Organização;
            this.btn_TelaOrganizacao.Location = new System.Drawing.Point(514, 69);
            this.btn_TelaOrganizacao.Name = "btn_TelaOrganizacao";
            this.btn_TelaOrganizacao.Size = new System.Drawing.Size(162, 172);
            this.btn_TelaOrganizacao.TabIndex = 1;
            this.btn_TelaOrganizacao.Text = "Organização";
            this.btn_TelaOrganizacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TelaOrganizacao.UseVisualStyleBackColor = true;
            this.btn_TelaOrganizacao.Click += new System.EventHandler(this.btn_TelaOrganizacao_Click);
            // 
            // btn_TelaCliente
            // 
            this.btn_TelaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TelaCliente.Image = global::PI_III.Properties.Resources.Cliente;
            this.btn_TelaCliente.Location = new System.Drawing.Point(90, 69);
            this.btn_TelaCliente.Name = "btn_TelaCliente";
            this.btn_TelaCliente.Size = new System.Drawing.Size(162, 172);
            this.btn_TelaCliente.TabIndex = 0;
            this.btn_TelaCliente.Text = "Cliente";
            this.btn_TelaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TelaCliente.UseVisualStyleBackColor = true;
            this.btn_TelaCliente.Click += new System.EventHandler(this.btn_TelaCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta Rapida de Produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_telainicial_buscar
            // 
            this.btn_telainicial_buscar.Location = new System.Drawing.Point(369, 424);
            this.btn_telainicial_buscar.Name = "btn_telainicial_buscar";
            this.btn_telainicial_buscar.Size = new System.Drawing.Size(86, 26);
            this.btn_telainicial_buscar.TabIndex = 4;
            this.btn_telainicial_buscar.Text = "Buscar";
            this.btn_telainicial_buscar.UseVisualStyleBackColor = true;
            this.btn_telainicial_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 487);
            this.Controls.Add(this.btn_telainicial_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TelaOrganizacao);
            this.Controls.Add(this.btn_TelaCliente);
            this.Name = "tela_inicial";
            this.Text = "Tela inicial";
            this.Load += new System.EventHandler(this.tela_inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TelaCliente;
        private System.Windows.Forms.Button btn_TelaOrganizacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_telainicial_buscar;
    }
}

