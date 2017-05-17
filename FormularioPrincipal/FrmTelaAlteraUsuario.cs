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
    public partial class FrmTelaAlteraUsuario : Form
    {
        public FrmTelaAlteraUsuario()
        {
            InitializeComponent();
        }

        private void FrmTelaAlteraUsuario_Load(object sender, EventArgs e)
        {
            

        }

        private void btnFrmAlteraUsuario_BuscarUsuario_Click(object sender, EventArgs e)
        {
            List<clsUsuario> alteraUsuarios = clsUsuario.SelecionarUsuario(txtFrmAlteraUsuario_buscarNomeUsuario.Text);
            dataGridView_AlteraUsuario.DataSource = alteraUsuarios;

            int i = dataGridView_AlteraUsuario.RowCount;
            MessageBox.Show("A busca Retornou " + i + " linhas");


        }

        private void dataGridView_AlteraUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFrmCadUsuario_nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_AlteraUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_AlteraUsuario.SelectedRows.Count > 0)
            {
                txtFrmAlteraUsuario_nomeUsuario.Text = dataGridView_AlteraUsuario.SelectedRows[0].Cells["nomeUsuario"].Value.ToString();
                txtFrmAlteraUsuario_loginUsuario.Text = dataGridView_AlteraUsuario.SelectedRows[0].Cells["loginUsuario"].Value.ToString();
                comboBoxAlteraUsuario_tipoPerfil.Text = dataGridView_AlteraUsuario.SelectedRows[0].Cells["tipoPerfil"].Value.ToString();
                string usuarioAtivo = dataGridView_AlteraUsuario.SelectedRows[0].Cells["usuarioAtivo"].Value.ToString();
                if (usuarioAtivo == "1")
                {
                    chkboxfrmCadUsuario_usuarioAtivo.Checked = true;
                }
                else
                {
                    chkboxfrmCadUsuario_usuarioAtivo.Checked = false;
                }

                //chkboxfrmCadUsuario_usuarioAtivo.Checked = dataGridView_AlteraUsuario.SelectedRows[0].Cells["tipoPerfil"].Value.ToString();
            }
        }

        private void pnCadUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFrmAlteraUsuario_nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_AlteraUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_tipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkboxfrmCadUsuario_usuarioAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbFrmCadUsuario_tipoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lbFrmCadUsuario_loginUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbFrmCadUsuario_nomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtFrmCadUsuario_loginUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbFrmAlteraUsuario_nomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnFrmAlteraUsuario_confirmaAlteracao_Click(object sender, EventArgs e)
        {

            clsUsuario alterarUsuario = new clsUsuario();

            alterarUsuario.idUsuario = Convert.ToInt32(dataGridView_AlteraUsuario.SelectedRows[0].Cells[0].Value.ToString());
            alterarUsuario.nomeUsuario = txtFrmAlteraUsuario_nomeUsuario.Text;
            alterarUsuario.loginUsuario = txtFrmAlteraUsuario_loginUsuario.Text;
            alterarUsuario.tipoPerfil = comboBoxAlteraUsuario_tipoPerfil.Text;
            alterarUsuario.usuarioAtivo = chkboxfrmCadUsuario_usuarioAtivo.Checked;

            alterarUsuario.Alterar();

            MessageBox.Show("Usuario Alterado!!!");
            Close();

        }
    }
}
