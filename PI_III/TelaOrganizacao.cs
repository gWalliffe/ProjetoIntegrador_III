using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_III
{
    public partial class TelaOrganizacao : Form
    {
        public TelaOrganizacao()
        {
            InitializeComponent();
        }

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCadastroCliente chamarCadastroCliente = new telaCadastroCliente();

            chamarCadastroCliente.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
