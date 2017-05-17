using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDataBase;

namespace FormularioPrincipal
{
    public partial class FrmTelaCadUsuario : Form
    {
        public FrmTelaCadUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkboxfrmCadUsuario_usuarioAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFrmCadCliente_confirmaCadastro_Click(object sender, EventArgs e)
        {
            clsUsuario salvarUsuario = new clsUsuario();

            salvarUsuario.nomeUsuario = txtFrmCadUsuario_nomeUsuario.Text;
            salvarUsuario.loginUsuario = txtFrmCadUsuario_loginUsuario.Text;
            salvarUsuario.usuarioAtivo = chkboxfrmCadUsuario_usuarioAtivo.Checked;
            salvarUsuario.senhaUsuario = txtFrmCadUsuario_senhaUsuario.Text;
            salvarUsuario.tipoPerfil = comboBoxCadUsuario_tipoUsuario.Text;

            salvarUsuario.Salvar();

            MessageBox.Show("Usuario Cadastrado!!!");
            Close();

        }

        private void btnFrmCadCliente_limpar_Click(object sender, EventArgs e)
        {
            txtFrmCadUsuario_nomeUsuario.Text = "";
            txtFrmCadUsuario_loginUsuario.Text = "";
            chkboxfrmCadUsuario_usuarioAtivo.Checked = false;
            txtFrmCadUsuario_senhaUsuario.Text = "";
            comboBoxCadUsuario_tipoUsuario.Text = "";
        }

        private void btnFrmCadCliente_logout_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_tipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
