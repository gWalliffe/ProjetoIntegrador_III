using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ConexaoDataBase;


namespace FormularioPrincipal
{
    public partial class FrmTelaCadProduto : Form
    {
        byte[] imagem;
        public FrmTelaCadProduto()
        {
            InitializeComponent();

            List<clsCategoria> Categoria = clsCategoria.selecionarCategoria();
            clsCategoria GetIdCategoria;
            comboBoxCadProduto_VisualizarCategoria.DataSource = Categoria;
            comboBoxCadProduto_VisualizarCategoria.ValueMember = "idCategoria";
            comboBoxCadProduto_VisualizarCategoria.DisplayMember = "nomeCategoria";
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

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFrmCadCliente_logout_Click(object sender, EventArgs e)
        {

        }

        private void btnFrmCadCliente_limpar_Click(object sender, EventArgs e)
        {

        }

        private void btnFrmCadCliente_confirmaCadastro_Click(object sender, EventArgs e)
        {
            clsProduto novoProduto = new clsProduto();

            novoProduto.nomeProduto = txtFrmCadProduto_nomeProduto.Text;
            novoProduto.descProduto = txtFrmCadProduto_descProduto.Text;
            novoProduto.precProduto = Convert.ToDecimal(txtFrmCadProduto_PrecProduto.Text);
            novoProduto.descontoPromocao = Convert.ToDecimal(txtFrmCadProduto_DescontoPromocao.Text);
            novoProduto.idCategoria = Convert.ToInt32(comboBoxCadProduto_VisualizarCategoria.SelectedValue);
            novoProduto.qtdMinEstoque = Convert.ToInt32(txtFrmCadProduto_qtdMinProduto.Text);
            novoProduto.ativoProduto = Convert.ToBoolean(rdb_ativoProduto.Checked);
            //rdb_ativoProduto.Checked == true ? novoProduto.ativoProduto = '1' : novoProduto.ativoProduto = '0';



            
            novoProduto.image = imagem;

            novoProduto.inserirProduto();

            MessageBox.Show("Produto Cadastrada!!!");
            Close();
        }

        private void mostraFoto(Byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(dados);
                pictureBoxCadProduto.Image = Image.FromStream(mem);
            }
            else
            {
                pictureBoxCadProduto.Image = null;
            }
        }
        private void txt_NomeCadastroProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTelaCadProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnFrmCadProduto_ProcurarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagem (*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    mostraFoto(File.ReadAllBytes(ofd.FileName));
                }
                else
                {
                    MessageBox.Show("Arquivo Inválido! Tente novamente...");
                }
            }
        }

        private void comboBoxCadProduto_VisualizarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
