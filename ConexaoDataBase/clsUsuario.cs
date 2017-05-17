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
    public class clsUsuario
    {
        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario{ get; set; }
        public string nomeUsuario { get; set; }
        public string tipoPerfil { get; set; }
        public bool usuarioAtivo { get; set; }

        //Faz desse objeto um Singleton
        private static clsUsuario referencia;

        public static clsUsuario getInstance()
        {
            if (referencia == null)
                referencia = new clsUsuario();

            return referencia;
        }
        public bool Logar(string loginUsuario, string senhaUsuario) {


            SqlConnection cn = clsConn.Conectar();
            clsUsuario u = null;

            bool result = false;

            try
            {
                string sql = (@"SELECT loginUsuario, nomeUsuario, tipoPerfil
                                FROM usuario
                                where loginUsuario = @loginUsuario
                                and senhaUsuario = @senhaUsuario
                                and usuarioAtivo = 1");

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@loginUsuario", SqlDbType.VarChar).Value = loginUsuario;
                cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar).Value = senhaUsuario;


                SqlDataReader dr = cmd.ExecuteReader();

                u = new clsUsuario();

                dr.Read();
                u.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                u.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                u.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                result = dr.HasRows;

                cn.Close();

            }
            catch(SqlException e)
            {
                throw new Exception(e.Message);

            }

            finally
            {
                cn.Close();
            }

            return result;

        }

        public void Salvar()
        {
            bool inserir = (this.idUsuario == 0);

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir) { 
                cmd.CommandText = "INSERT INTO usuario " +
                                "(loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo)" +
                                "VALUES " +
                                "(@loginUsuario, @senhaUsuario, @nomeUsuario, @tipoPerfil, @usuarioAtivo)";
           
                cmd.Parameters.Add("idCliente", SqlDbType.Int).Value = idUsuario;
            }

            cmd.Parameters.Add("@loginUsuario", SqlDbType.VarChar, 100).Value = this.loginUsuario;
            cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar, 64).Value = this.senhaUsuario;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar, 50).Value = this.nomeUsuario;
            cmd.Parameters.Add("@tipoPerfil", SqlDbType.VarChar, 10).Value = this.tipoPerfil;
            cmd.Parameters.Add("@usuarioAtivo", SqlDbType.Bit).Value = usuarioAtivo;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsUsuario> SelecionarUsuario(string nomeUsuario)
        {
            //COMANDO SQL
            string sql = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM usuario " +
                "WHERE nomeUsuario like '%"+nomeUsuario+"%'";
            
            //INICIANDO CONEXAO COM O BANCO
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar).Value = nomeUsuario;

            //INSTANCIANDO DataReader
            SqlDataReader dr = cmd.ExecuteReader();

            //criando lista para guardar usuarios retornados do COMANDO SQL
            List<clsUsuario> Usuarios = new List<clsUsuario>();
            while (dr.Read())//ENQUANDO MEU COMANDO DO SQL ESTIVER SENDO VERIFICADO ATRAVÉS DO COMANDO QUE le O BANCO
            {

                clsUsuario C = new clsUsuario();

                //MEUS REGISTROS NO BANCO SE ESPELHARAM PARA MEUS ATRIBUTOS NA CLASSE.
            
                C.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                C.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                C.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                C.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                C.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                C.usuarioAtivo = dr.GetBoolean(dr.GetOrdinal("usuarioAtivo"));
                Usuarios.Add(C);
            }

            //FECHA CONEXÃO
            cn.Close();

            //RETORNA LISTA DE USUARIOS
            return Usuarios;
        }

        public void Alterar() {

            //CRIANDO CONEXAO
            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            //SE EXISTIR USUARIO 
            if (idUsuario > 1)
            {
                cmd.CommandText = "UPDATE usuario " +
                                        "SET loginUsuario = '"+loginUsuario+"', " +
                                        "nomeUsuario = '"+nomeUsuario+"', " +
                                        "tipoPerfil = '"+tipoPerfil+"', " +
                                        "usuarioAtivo = @usuarioAtivo " +
                                        "WHERE idUsuario = @idUsuario";

            }

            //PASSO OS PARAMETROS PARA O COMANDO DE TEXTO DO UPDATE
            cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
            //cmd.Parameters.Add("@loginUsuario", SqlDbType.VarChar).Value = loginUsuario;
            //cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar).Value = nomeUsuario;
           // cmd.Parameters.Add("@tipoPerfil", SqlDbType.VarChar).Value = tipoPerfil;
            cmd.Parameters.Add("@usuarioAtivo", SqlDbType.Bit).Value = usuarioAtivo;
            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public void Deletar()
        {

            SqlConnection cn = clsConn.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (idUsuario > 1)
            {
                cmd.CommandText = "DELETE from usuario " +
                                    "WHERE idUsuario = @idUsuario";

            }
            //PASSO OS PARAMETROS PARA O COMANDO DE TEXTO DO UPDATE
            cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
            cmd.ExecuteNonQuery();

            cn.Close();

        }


    }
}
