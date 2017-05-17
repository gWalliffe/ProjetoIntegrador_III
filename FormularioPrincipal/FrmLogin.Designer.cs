namespace FormularioPrincipal
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.painel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btResetar = new System.Windows.Forms.Button();
            this.btEntrar = new System.Windows.Forms.Button();
            this.pnTelaLogin_senhaUsuario = new System.Windows.Forms.Label();
            this.pnTelaLogin_loginUsuario = new System.Windows.Forms.Label();
            this.txtTelaLogin_senhaUsuario = new System.Windows.Forms.TextBox();
            this.txtTelaLogin_loginUsuario = new System.Windows.Forms.TextBox();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.painel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel.Controls.Add(this.pictureBox1);
            this.painel.Controls.Add(this.btResetar);
            this.painel.Controls.Add(this.btEntrar);
            this.painel.Controls.Add(this.pnTelaLogin_senhaUsuario);
            this.painel.Controls.Add(this.pnTelaLogin_loginUsuario);
            this.painel.Controls.Add(this.txtTelaLogin_senhaUsuario);
            this.painel.Controls.Add(this.txtTelaLogin_loginUsuario);
            this.painel.Location = new System.Drawing.Point(-4, -1);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(353, 464);
            this.painel.TabIndex = 0;
            this.painel.Paint += new System.Windows.Forms.PaintEventHandler(this.painelLogin_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btResetar
            // 
            this.btResetar.BackColor = System.Drawing.Color.Red;
            this.btResetar.Location = new System.Drawing.Point(199, 301);
            this.btResetar.Name = "btResetar";
            this.btResetar.Size = new System.Drawing.Size(81, 35);
            this.btResetar.TabIndex = 5;
            this.btResetar.Text = "Reset";
            this.btResetar.UseVisualStyleBackColor = false;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btEntrar.Location = new System.Drawing.Point(107, 301);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(81, 35);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // pnTelaLogin_senhaUsuario
            // 
            this.pnTelaLogin_senhaUsuario.AutoSize = true;
            this.pnTelaLogin_senhaUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnTelaLogin_senhaUsuario.Location = new System.Drawing.Point(47, 264);
            this.pnTelaLogin_senhaUsuario.Name = "pnTelaLogin_senhaUsuario";
            this.pnTelaLogin_senhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.pnTelaLogin_senhaUsuario.TabIndex = 3;
            this.pnTelaLogin_senhaUsuario.Text = "Senha";
            // 
            // pnTelaLogin_loginUsuario
            // 
            this.pnTelaLogin_loginUsuario.AutoSize = true;
            this.pnTelaLogin_loginUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnTelaLogin_loginUsuario.Location = new System.Drawing.Point(49, 211);
            this.pnTelaLogin_loginUsuario.Name = "pnTelaLogin_loginUsuario";
            this.pnTelaLogin_loginUsuario.Size = new System.Drawing.Size(33, 13);
            this.pnTelaLogin_loginUsuario.TabIndex = 2;
            this.pnTelaLogin_loginUsuario.Text = "Login";
            // 
            // txtTelaLogin_senhaUsuario
            // 
            this.txtTelaLogin_senhaUsuario.Location = new System.Drawing.Point(107, 261);
            this.txtTelaLogin_senhaUsuario.Name = "txtTelaLogin_senhaUsuario";
            this.txtTelaLogin_senhaUsuario.Size = new System.Drawing.Size(173, 20);
            this.txtTelaLogin_senhaUsuario.TabIndex = 1;
            this.txtTelaLogin_senhaUsuario.Text = "Senha";
            this.txtTelaLogin_senhaUsuario.UseSystemPasswordChar = true;
            // 
            // txtTelaLogin_loginUsuario
            // 
            this.txtTelaLogin_loginUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTelaLogin_loginUsuario.Location = new System.Drawing.Point(107, 208);
            this.txtTelaLogin_loginUsuario.Name = "txtTelaLogin_loginUsuario";
            this.txtTelaLogin_loginUsuario.Size = new System.Drawing.Size(173, 20);
            this.txtTelaLogin_loginUsuario.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 460);
            this.Controls.Add(this.painel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tela de Login";
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Label pnTelaLogin_senhaUsuario;
        private System.Windows.Forms.Label pnTelaLogin_loginUsuario;
        private System.Windows.Forms.TextBox txtTelaLogin_senhaUsuario;
        private System.Windows.Forms.TextBox txtTelaLogin_loginUsuario;
        private System.Windows.Forms.Button btResetar;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}