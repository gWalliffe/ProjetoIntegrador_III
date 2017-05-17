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
    public partial class FrmTelaAlteraCategoria : Form
    {
        public FrmTelaAlteraCategoria()
        {
            InitializeComponent();
        }

        private void txtFrmAlteraCategoria_nomeCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFrmAlteraCategoria_confirmaAlteracao_Click(object sender, EventArgs e)
        {

            clsCategoria alterarCategoria = new clsCategoria();

            alterarCategoria.idCategoria = Convert.ToInt32(dataGridView_AlteraCategoria.SelectedRows[0].Cells[0].Value.ToString());
            alterarCategoria.nomeCategoria = txtFrmAlteraCategoria_nomeCategoria.Text;
            alterarCategoria.descCategoria = txtFrmAlteraCategoria_descCategoria.Text;

            alterarCategoria.alterarCategoria();

            MessageBox.Show("Categoria Alterada!!!");
            Close();
        }

        private void btnFrmAlteraCategoria_BuscarCategoria_Click(object sender, EventArgs e)
        {
            List<clsCategoria> alteraCategoria = clsCategoria.selecionarCategoria(txtFrmAlteraCategoria_nomeCategoria.Text);
            dataGridView_AlteraCategoria.DataSource = alteraCategoria;

            int i = dataGridView_AlteraCategoria.RowCount;
            MessageBox.Show("A busca Retornou " + i + " linhas");
        }

        private void dataGridView_AlteraCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_AlteraCategoria.SelectedRows.Count > 0)
            {
                txtFrmAlteraCategoria_nomeCategoria.Text = dataGridView_AlteraCategoria.SelectedRows[0].Cells["nomeCategoria"].Value.ToString();
                txtFrmAlteraCategoria_descCategoria.Text = dataGridView_AlteraCategoria.SelectedRows[0].Cells["descCategoria"].Value.ToString();
            }
        }
    }
}
