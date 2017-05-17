using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConexaoDataBase;

namespace ConexaoDataBase
{
    public class clsProduto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public decimal precProduto { get; set; }
        public decimal descontoPromocao { get; set; }
        public int idCategoria { get; set; }
        public bool ativoProduto { get; set; }
        public int idUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public byte[] image { get; set; }
        

        //Faz desse objeto um Singleton
        private static clsProduto referencia;

        public static clsProduto getInstance()
        {
            if (referencia == null)
                referencia = new clsProduto();

            return referencia;
        }

        public void inserirProduto()
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            try
            {
                cmd.CommandText = "INSERT INTO produto " +
                            "(nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque) VALUES " +
                            "(@nomeProduto, @descProduto, @precProduto, @descontoPromocao, @idCategoria, @ativoProduto, 1, @qtdMinEstoque)";

                //cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
                cmd.Parameters.Add("nomeProduto", SqlDbType.VarChar, 70).Value = nomeProduto;
                cmd.Parameters.Add("descProduto", SqlDbType.VarChar, 500).Value = descProduto;
                cmd.Parameters.Add("precProduto", SqlDbType.Money, 8).Value = precProduto;
                cmd.Parameters.Add("descontoPromocao", SqlDbType.Decimal, 9).Value = descontoPromocao;
                cmd.Parameters.Add("idCategoria", SqlDbType.Int).Value = idCategoria;
                cmd.Parameters.Add("ativoProduto", SqlDbType.Bit, 1).Value = ativoProduto;
                //cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value = idUsuario;
                cmd.Parameters.Add("qtdMinEstoque", SqlDbType.Int).Value = qtdMinEstoque;
                //cmd.Parameters.Add("imagem", SqlDbType.Image, 50).Value = (byte[])image;

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idCategoria = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            cn.Close();
            cn.Dispose();
        }



    }
}
