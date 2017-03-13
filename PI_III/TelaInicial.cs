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
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tela_inicial_Load(object sender, EventArgs e)
        {

        }

        private void btn_TelaCliente_Click(object sender, EventArgs e)
        {
            TelaCliente chamarTelaCliente = new TelaCliente();

            chamarTelaCliente.Show();
        }

        private void btn_TelaOrganizacao_Click(object sender, EventArgs e)
        {
            TelaOrganizacao chamarTelaOrganizacao = new TelaOrganizacao();

            chamarTelaOrganizacao.Show();
        }
    }
}
