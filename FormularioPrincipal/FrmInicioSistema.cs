using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPrincipal
{
    public partial class FrmInicioSistema : Form
    {
        //Variável _objForm é para controlar as propriedade dos forms
        private Form _objForm;
        //
        

        //
        public FrmInicioSistema()
        {
            InitializeComponent();
        }

        private void FrmInicioSistema_Load(object sender, EventArgs e)
        {
            // Get the current Real Time.
            timer1.Enabled  = true;
            timer1.Interval = 25;
            //
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay   = 5000;
            toolTip1.InitialDelay   = 1000;
            toolTip1.ReshowDelay    = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways     = true;

            // Set up the ToolTip text for the Button and Checkbox.
            
            toolTip1.SetToolTip(this.btnInicioSistemaCategoriaAdd,     "Cadastro de Categoria");
            toolTip1.SetToolTip(this.btnInicioSistemaProdutoAdd,    "Cadastro de Produto");
            toolTip1.SetToolTip(this.btnInicioSistemaUsuarioAdd,    "Cadastro de Usuário");
            toolTip1.SetToolTip(this.btnInicioSistemaUpdateUsuario,      "Alterar Usuário");
            toolTip1.SetToolTip(this.btnInicioSistemaChangeUser,    "Trocar Usuário");
            toolTip1.SetToolTip(this.btnInicioSistemaUpdateCategoria, "Alterar Categoria");
            toolTip1.SetToolTip(this.btnInicioSistemaUpdateProduto, "Alterar Produto");
            toolTip1.SetToolTip(this.btnInicioSistemaUpdateEstoque, "Alterar Estoque");
            toolTip1.SetToolTip(this.btnInicioSistemaViewEstoque, "Visualizar Estoque");
            toolTip1.SetToolTip(this.btnInicioSistemaViewCategoria, "Visualizar Categoria");
            toolTip1.SetToolTip(this.btnInicioSistemaViewProduto, "Visualizar Produto");
            toolTip1.SetToolTip(this.btnInicioSistemaViewUsuario, "Visualizar Usuário");
            //

            //

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the current date.
            DateTime thisDay = DateTime.Today;
            lbInicioSistemaGetDate.Text = thisDay.ToString("D") +"   |   " +DateTime.Now.ToLongTimeString();
        }

        

        private void btnInicioSistemaProdutoAdd_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaCadProduto
            {
                TopLevel        = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock            = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
            //
            //pnInicioSistemaRecebeDecisoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
        }

        private void btnInicioSistemaPedidoAdd_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaCadCategoria
            {
                TopLevel        = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock            = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
            //
            //pnInicioSistemaRecebeDecisoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
        }

        private void btnInicioSistemaUsuarioAdd_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaCadUsuario
            {
                TopLevel        = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock            = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
            //
            //pnInicioSistemaRecebeDecisoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
        }

        
        private void btnInicioSistemaChangeUser_Click(object sender, EventArgs e)
        {
            
            FrmLogin efetuarLogoff = new FrmLogin();
            efetuarLogoff.Show();
            this.Close();

        }

        

        private void pnInicioSistemaTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicioSistemaVendaAdd_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaAlteraUsuario
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
            //
            //pnInicioSistemaRecebeDecisoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
        }

        private void btnInicioSistemaUpdateCategoria_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaAlteraCategoria
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();

        }

        private void btnInicioSistemaUpdateProduto_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaAlteraProduto
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSistemaViewUsuario_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaVisualizaUsuario
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnInicioSistemaViewCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInicioSistemaViewProduto_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaVisualizaProduto
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSistemaUpdateEstoque_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaAlteraEstoque
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnInicioSistemaViewCategoria_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaVisualizaCategoria
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnInicioSistemaViewEstoque_Click(object sender, EventArgs e)
        {
            _objForm?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            _objForm = new FrmTelaVisualizaEstoque
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            //
            pnInicioSistemaRecebeTelas.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
