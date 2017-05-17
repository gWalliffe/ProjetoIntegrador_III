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
    public partial class FrmTelaCadCategoria : Form
    {
        public FrmTelaCadCategoria()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close(); //Fecha somente a tela.
                         //Application.Exit(); (Fecha a aplicação)
                         //
            }
        }

        private void btnFrmCadCliente_limpar_Click(object sender, EventArgs e)
        {

        }

        private void btnFrmCadCliente_confirmaCadastro_Click(object sender, EventArgs e)
        {
            clsCategoria novaCategoria = new clsCategoria();

            novaCategoria.nomeCategoria = txtFrmCadCategoria_nomeCategoria.Text;
            novaCategoria.descCategoria = txtFrmCadCategoria_descCategoria.Text;

            novaCategoria.novaCategoria();

            MessageBox.Show("Categoria Cadastrada!!!");
            Close();
        }
    }
}
