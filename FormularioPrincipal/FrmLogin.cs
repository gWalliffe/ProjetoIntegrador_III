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
    public partial class FrmLogin : Form
    {
        private bool Logado = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void painelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            clsUsuario login = new clsUsuario();

            if(txtTelaLogin_loginUsuario.Text != null && txtTelaLogin_senhaUsuario.Text != null) { 
                bool result = login.Logar(txtTelaLogin_loginUsuario.Text, txtTelaLogin_senhaUsuario.Text);

                Logado = result;
                if (result)
                {
                    FrmInicioSistema abrirInicioSistema = new FrmInicioSistema();
                    MessageBox.Show("Seja bem vindo!");
                    this.Hide();
                    abrirInicioSistema.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            }
            else
            {
                MessageBox.Show("Digite os dados para login");
            }
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

            
        }
    }
}
