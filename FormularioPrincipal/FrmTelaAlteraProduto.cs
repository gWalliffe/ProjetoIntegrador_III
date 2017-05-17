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
    public partial class FrmTelaAlteraProduto : Form
    {
        public FrmTelaAlteraProduto()
        {
            InitializeComponent();

            List<clsCategoria> Categoria = clsCategoria.selecionarCategoria();

            comboBoxAlteraProduto_VisualizaCategoria.DataSource = Categoria;
            comboBoxAlteraProduto_VisualizaCategoria.ValueMember = "idCategoria";
            comboBoxAlteraProduto_VisualizaCategoria.DisplayMember = "nomeCategoria";
        }

        private void FrmTelaAlteraProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
