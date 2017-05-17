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
    public partial class FrmTelaVisualizaCategoria : Form
    {
        public FrmTelaVisualizaCategoria()
        {
            InitializeComponent();
        }

        private void btnFrmVisualizaCategoria_BuscarCategoria_Click(object sender, EventArgs e)
        {
            List<clsCategoria> Categorias = clsCategoria.selecionarCategoria(txtFrmVisualizaCategoria_BuscaNomeCategoria.Text);
            dataGridView_VisualizarCategoria.DataSource = Categorias;

            int i = dataGridView_VisualizarCategoria.RowCount;
            MessageBox.Show("A busca Retornou " + i + " linhas");
        }

        private void dataGridView_VisualizarCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_VisualizarCategoria.SelectedRows.Count > 0)
            {
                txtFrmVisualizaCategoria_nomeCategoria.Text = dataGridView_VisualizarCategoria.SelectedRows[0].Cells["nomeCategoria"].Value.ToString();
                if (dataGridView_VisualizarCategoria.SelectedRows[0].Cells["descCategoria"].Value == null)
                {
                    txtFrmVisualizaCategoria_descCategoria.Text = "";
                }
                else
                {
                    txtFrmVisualizaCategoria_descCategoria.Text = dataGridView_VisualizarCategoria.SelectedRows[0].Cells["descCategoria"].Value.ToString();
                }
            }
        }

        private void btnTelaVisualizaCategoria_deletarCategoria_Click(object sender, EventArgs e)
        {
            clsCategoria deletarCategoria = new clsCategoria();

            deletarCategoria.idCategoria = Convert.ToInt32(dataGridView_VisualizarCategoria.SelectedRows[0].Cells[0].Value.ToString());

            deletarCategoria.deletarCategoria();

            MessageBox.Show("Categoria Deletada!!!");
            Close();
        }
    }
}
