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
    public partial class FrmTelaVisualizaUsuario : Form
    {
        public FrmTelaVisualizaUsuario()
        {
            InitializeComponent();
        }

        private void btnFrmVisualizaUsuario_BuscarUsuario_Click(object sender, EventArgs e)
        {
            List<clsUsuario> Usuarios = clsUsuario.SelecionarUsuario(txtFrmVisualizaUsuario_nomeUsuario.Text);
            dataGridView_VisualizaUsuario.DataSource = Usuarios;
            dataGridView_VisualizaUsuario.Columns["senhaUsuario"].Visible = false;

            int i = dataGridView_VisualizaUsuario.RowCount;
            MessageBox.Show("A busca Retornou " + i + " linhas");


        }

        private void dataGridView_VisualizaUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_VisualizaUsuario.SelectedRows.Count > 0)
            {
                txtFrmVisualizaUsuario_nomeUsuario2.Text = dataGridView_VisualizaUsuario.SelectedRows[0].Cells["nomeUsuario"].Value.ToString();
                txtFrmVisualizaUsuario_loginUsuario.Text = dataGridView_VisualizaUsuario.SelectedRows[0].Cells["loginUsuario"].Value.ToString();
                comboBoxVisualizaUsuario_tipoPerfil.Text = dataGridView_VisualizaUsuario.SelectedRows[0].Cells["tipoPerfil"].Value.ToString();
                string usuarioAtivo = dataGridView_VisualizaUsuario.SelectedRows[0].Cells["usuarioAtivo"].Value.ToString();
                if (usuarioAtivo == "1")
                {
                    chkboxfrmVisualizaUsuario_usuarioAtivo.Checked = false;
                }
                else
                {
                    chkboxfrmVisualizaUsuario_usuarioAtivo.Checked = true;
                }

                //chkboxfrmCadUsuario_usuarioAtivo.Checked = dataGridView_AlteraUsuario.SelectedRows[0].Cells["tipoPerfil"].Value.ToString();
            }
        }

        private void btnTelaVisualizaUsuario_deletarUsuario_Click(object sender, EventArgs e)
        {
            clsUsuario deletarUsuario = new clsUsuario();

            deletarUsuario.idUsuario = Convert.ToInt32(dataGridView_VisualizaUsuario.SelectedRows[0].Cells[0].Value.ToString());

            deletarUsuario.Alterar();

            MessageBox.Show("Usuario Deletado!!!");
            Close();
        }
    }
}
