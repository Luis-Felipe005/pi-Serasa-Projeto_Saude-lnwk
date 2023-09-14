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
        //Casa
        //const string host = "localhost";
        //const string banco = "projetobanco";
        //const string usuario = "root";
        //const string senha = "";


        //Senac
        const string host = "srv793.hstgr.io";
        const string banco = "u647084545_serasa_lnw";
        const string usuario = "u647084545_serasa_lnw";
        const string senha = "Serasa2023";

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