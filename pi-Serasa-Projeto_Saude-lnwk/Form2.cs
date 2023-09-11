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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            panel1.Size = new Size(ClientSize.Width, 100);

            panel2.Width = Width;
            panel2.Location = new System.Drawing.Point(0, Height - panel2.Height);

            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2, ClientSize.Height / 2 - painelMeio.Size.Height / 2);

            lblOpcoes.Location = new Point(ClientSize.Width / 2 - lblOpcoes.Size.Width / 2);

        }

        //public void CarregaForms()
        //{
        RecepcaoAtendente atendente = new RecepcaoAtendente();

        //  atendente.Show();







        private void btnCancelar_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            HealtHub healtHub = new HealtHub();
            healtHub.TopLevel = false;
            panel1.Controls.Add(healtHub);
            healtHub.Show();



        }

        private void btnSangue_Click(object sender, EventArgs e)
        {

            painelMeio.Visible = false;
            Bancosangue bancosangue = new Bancosangue();
            bancosangue.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;
            };
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            bancosangue.TopLevel = false;
            panel1.Controls.Add(bancosangue);
            bancosangue.Show();






        }

        private void btnVacina_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            Vacinacao vacinacao = new Vacinacao();
            vacinacao.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;
            };
            vacinacao.TopLevel = false;
            panel1.Controls.Add(vacinacao);
            vacinacao.Show();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            ColetaExame coletaExame = new ColetaExame();
            coletaExame.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;
            };
            coletaExame.TopLevel = false;
            panel1.Controls.Add(coletaExame);
            coletaExame.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            panel2.Visible = false;
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            Consulta consulta = new Consulta();
            consulta.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;

            };
            consulta.TopLevel = false;
            panel1.Controls.Add(consulta);
            consulta.Show();
        }
    }
}
