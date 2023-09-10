using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_Serasa_Projeto_Saude_lnwk
{
    public partial class HealtHub : Form
    {
        public HealtHub()
        {
            InitializeComponent();
            txtCpf.Select();
            txtSenha.Select();
        }

        private void HealtHub_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;

            // panel1.Size = new Size(ClientSize.Width, 100);

            // lblBemvindo.Location = new Point(ClientSize.Width / 2 - lblBemvindo.Size.Width / 2);

            //  painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2, ClientSize.Height / 2 - painelMeio.Size.Height / 2);

        }

        private void HealtHub_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            panel1.Size = new Size(ClientSize.Width, 100);

            lblBemvindo.Location = new Point(ClientSize.Width / 2 - lblBemvindo.Size.Width / 2);

            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2, ClientSize.Height / 2 - painelMeio.Size.Height / 2);

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string CPF = txtCpf.Text;
            string Senha = txtSenha.Text;

            Paciente paciente = new Paciente();
            //paciente = paciente.login(CPF, Senha);

            if (paciente == null)
            {

                MessageBox.Show("CPF ou Senha incorreto");
                return;

            }




            HealtHub healtHub = new HealtHub();
            healtHub.TopLevel = false;

            Form1.panel1.Controls.Clear();

            Form1.panel1.Controls.Add(healtHub);
            healtHub.Show();
        }

        internal class Paciente
        {

            public int id;
            public string nome;
            public string CPF;
            public string Senha;



            public Paciente()
            {

            }

            public Paciente(int id, string nome, string cpf, string senha)
            {
                this.id = id;
                this.nome = nome;
                this.CPF = cpf;
                this.Senha = senha;
            }

            public List<Paciente> buscaTodos()
            {

                string query = "SELECT * FROM pacientes;";

                DataTable resultados = Conexao.executaQuery(query);
                if (resultados == null)
                    return null;

                List<Paciente> pacientes = new List<Paciente>();
                foreach (DataRow row in resultados.Rows)
                {
                    Paciente paciente = carregaDados(row);
                    pacientes.Add(paciente);
                }

                return pacientes;

            }

            public List<Paciente> buscaTodosPorIdUsuario(int id)
            {

                string query = $"SELECT * FROM pacientes WHERE id = {id};";

                DataTable resultados = Conexao.executaQuery(query);
                if (resultados == null)
                    return null;

                List<Paciente> pacientes = new List<Paciente>();
                foreach (DataRow row in resultados.Rows)
                {
                    Paciente paciente = carregaDados(row);
                    pacientes.Add(paciente);
                }

                return pacientes;

            }

            public Paciente buscaPorId(int id)
            {
                string query = "SELECT * FROM pacientes WHERE id = " + id + " LIMIT 1;";

                DataTable resultados = Conexao.executaQuery(query);
                if (resultados.Rows.Count == 0)
                    return null;

                Paciente paciente = carregaDados(resultados.Rows[0]);
                return paciente;

            }

            public void insere(Paciente paciente)
            {
                string query = $"INSERT INTO pacientes (id, nome, cpf,senha) VALUES ({paciente.id}, '{paciente.nome}', {paciente.CPF} {paciente.Senha});";
                Conexao.executaQuery(query);
            }


            private Paciente carregaDados(DataRow row)
            {
                int id = int.Parse(row["id"].ToString());
                string Nome = row["Nome"].ToString();
                string CPF = row["CPF"].ToString();
                string Senha = row["Senha"].ToString();

                Paciente pacientes = new Paciente(id, Nome, CPF, Senha);
                return pacientes;
            }


        }
    }
}

