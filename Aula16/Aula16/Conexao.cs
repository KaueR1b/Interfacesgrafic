using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16
{
    class Conexao
    {
        private static string conexao = @"server=localhost;port3306;user id=root;pwd=usbw;datebase=bd_aula16";
        private static MySqlConnection connection = new MySqlConnection(conexao);
        private bool resultado;
        private MySqlCommand comando;

        public bool ComandoSql(string sql)
        {
            try
            {
                connection.Open();
                comando = new MySqlCommand(sql, connection);
                comando.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                Console.WriteLine("Erro!" + ex);
            }
            finally
            {
                connection.Close();
            }
            return resultado;
        }

        public DataTable Busca(string sql)
        {
            try
            {
                connection.Open();
                comando = new MySqlCommand(sql, connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro!" + ex);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
