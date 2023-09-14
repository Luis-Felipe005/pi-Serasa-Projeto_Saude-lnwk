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


            lblBemvindo.Location = new Point(ClientSize.Width / 2 - lblBemvindo.Size.Width / 2);
           // panelCentral.Size = new Size(ClientSize.Width-400, ClientSize.Height-500);

           // painelMeio.Location = new Point(ClientSize.Width / 2 - panelCentral.Size.Width / 2, ClientSize.Height / 2+50 - panelCentral.Size.Height / 2+50);

            var strConexao = "server=localhost;uid=root;pwd=senac;database=cadastro";
            var conexao = new MySqlConnection(strConexao);

            conexao.Open();
        }


        MySqlConnection conexao1 = new MySqlConnection(Properties.Settings.Default.conexao);

        string usuario, senha;



        private void btnEntrar_Click(object sender, EventArgs e)
        {


            Logar();



            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Logar()
        {
            string login = "SELECT CPF, Senha FROM pacientes WHERE CPF='" + txtCpf.Text + "' AND Senha='" + txtSenha.Text + "'";
            MySqlCommand comando = new MySqlCommand(login, conexao1);
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader;

            try
            {

                conexao1.Open();
                reader = comando.ExecuteReader();
                if (reader.Read())
                {

                    usuario = reader[0].ToString();
                    senha = reader[1].ToString();

                    conexao1.Close();

                    if (usuario == txtCpf.Text && senha == txtSenha.Text)
                    {

                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();

                    }


                }


            }

            catch (Exception ex)
            {

                MessageBox.Show("Deu erro" + ex);



            }
        }




    
    }
}

