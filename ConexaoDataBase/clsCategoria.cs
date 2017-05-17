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
    public class clsCategoria
    {

        public int idCategoria { get; set; }
        public string nomeCategoria { get; set; }
        public string descCategoria { get; set; }

        public static clsCategoria referencia;

        public static clsCategoria getInstance()
        {
            if (referencia == null)
                referencia = new clsCategoria();

            return referencia;
        }

        public void novaCategoria()
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            try
            {
                cmd.CommandText = "INSERT INTO categoria " +
                            "(nomeCategoria, descCategoria) VALUES " +
                            "(@nomeCategoria, @descCategoria)";

                cmd.Parameters.Add("idCategoria", SqlDbType.Int).Value = idCategoria;
                cmd.Parameters.Add("nomeCategoria", SqlDbType.VarChar, 50).Value = nomeCategoria;
                cmd.Parameters.Add("descCategoria", SqlDbType.VarChar, 100).Value = descCategoria;

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

        public static List<clsCategoria> selecionarCategoria(String nomeCategoria)
        {
            //COMANDO SQL
            string sql = (@"SELECT idCategoria, nomeCategoria, descCategoria
                                FROM categoria
                                where nomeCategoria like '%" + nomeCategoria + "%'");

            //INICIANDO CONEXAO COM O BANCO
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar).Value = nomeCategoria;

            //INSTANCIANDO DataReader
            SqlDataReader dr = cmd.ExecuteReader();

            //criando lista para guardar usuarios retornados do COMANDO SQL
            List<clsCategoria> Categorias = new List<clsCategoria>();
            while (dr.Read())//ENQUANDO MEU COMANDO DO SQL ESTIVER SENDO VERIFICADO ATRAVÉS DO COMANDO QUE le O BANCO
            {

                clsCategoria C = new clsCategoria();

                //MEUS REGISTROS NO BANCO SE ESPELHARAM PARA MEUS ATRIBUTOS NA CLASSE.

                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }

                Categorias.Add(C);
            }

            //FECHA CONEXÃO
            cn.Close();
            cn.Dispose();

            //RETORNA LISTA DE USUARIOS
            return Categorias;
        }

        public static List<clsCategoria> selecionarCategoria()
        {
            //COMANDO SQL
            string sql = (@"SELECT idCategoria, nomeCategoria, descCategoria
                                FROM categoria");

            //INICIANDO CONEXAO COM O BANCO
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            //INSTANCIANDO DataReader
            SqlDataReader dr = cmd.ExecuteReader();

            //criando lista para guardar usuarios retornados do COMANDO SQL
            List<clsCategoria> Categorias = new List<clsCategoria>();
            while (dr.Read())//ENQUANDO MEU COMANDO DO SQL ESTIVER SENDO VERIFICADO ATRAVÉS DO COMANDO QUE le O BANCO
            {

                clsCategoria C = new clsCategoria();

                //MEUS REGISTROS NO BANCO SE ESPELHARAM PARA MEUS ATRIBUTOS NA CLASSE.

                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }

                Categorias.Add(C);
            }

            //FECHA CONEXÃO
            cn.Close();
            cn.Dispose();

            //RETORNA LISTA DE USUARIOS
            return Categorias;
        }
        //DELETE
        public void deletarCategoria()
        {
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (idCategoria > 1)
            {
                cmd.CommandText = "DELETE from categoria " +
                                    "WHERE idCategoria = @idCategoria";

            }
            //PASSO OS PARAMETROS PARA O COMANDO DE TEXTO DO UPDATE
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
            cmd.ExecuteNonQuery();

            cn.Close();
        }
        //UPDATE
        public void alterarCategoria()
        {
            //CRIANDO CONEXAO
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            //SE EXISTIR USUARIO 
            if (idCategoria > 1)
            {
                cmd.CommandText = "UPDATE categoria " +
                                        "SET nomeCategoria = '" + nomeCategoria + "', " +
                                        "descCategoria = '" + descCategoria + "' " +
                                        "WHERE idCategoria = @idCategoria";

            }

            //PASSO OS PARAMETROS PARA O COMANDO DE TEXTO DO UPDATE
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
            cmd.ExecuteNonQuery();

            cn.Close();
        }
    }
}