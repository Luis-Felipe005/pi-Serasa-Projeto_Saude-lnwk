using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_Serasa_Projeto_Saude_lnwk
{
    internal class Conexao
    {

        /*
         * EXEMPLO DE CONEXÃO GENÉRICA QUE PODE SER INTEGRADA COM QUALQUER CLASSE
        */

        const string host = "10.60.45.28";
        const string banco = "cadastro";
        const string usuario = "senac";
        const string senha = "senac";

        public static MySqlConnection connection =
            new MySqlConnection($"Server={host};Database={banco};Uid={usuario};Pwd={senha};");

        public static DataTable executaQuery(string query)
        {

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(read);
                return dataTable;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao realizar consulta:");
                Console.WriteLine(erro.Message);
                return null;
            }
            finally
            {
                connection.Dispose();
            }

        }


    }
}