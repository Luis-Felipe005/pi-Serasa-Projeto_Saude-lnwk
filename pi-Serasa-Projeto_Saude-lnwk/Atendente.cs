using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_Serasa_Projeto_Saude_lnwk
{
    internal class Atendente
    {

        public string nome;
        public int idade;
        public string sexo;
        public string cpf;

        public Atendente()
        {

        }

        public Atendente(string nome, int idade, string sexo, string cpf)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.cpf = cpf;

        }
        public List<Atendente> buscaTodos()
        {

            string query = "SELECT * FROM atendente;";

            DataTable resultados = Conexao.executaQuery(query);
            if (resultados == null)
                return null;

            List<Atendente> atendentes = new List<Atendente>();
            foreach (DataRow row in resultados.Rows)
            {
                Atendente atendente = carregaDados(row);
                atendentes.Add(atendente);
            }

            return atendentes;

        }

        public Atendente buscaPorId(int id)
        {
            string query = "SELECT * FROM Atendentes WHERE id = " + id + " LIMIT 1;";

            DataTable resultados = Conexao.executaQuery(query);
            if (resultados.Rows.Count == 0)
                return null;

            Atendente Atendente = carregaDados(resultados.Rows[0]);
            return Atendente;

        }

        public void removePorId(int id)
        {
            string query = $"DELETE FROM Atendentes WHERE id = {id};";
            Conexao.executaQuery(query);
        }

        

        private Atendente carregaDados(DataRow row)
        {
            int idade = int.Parse(row["Idade_ver"].ToString());
            string nome = row["Nome_ver"].ToString();
            string sexo = row["Sexo_ver"].ToString() ;
            string cpf = row["CPF_ver"].ToString();

            Atendente Atendente = new Atendente(nome,idade, sexo, cpf);
            return Atendente;
        }

    }
}