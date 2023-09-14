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


            panelFundo.Size = new Size(ClientSize.Width + 950, ClientSize.Height + 500);
            panelFundo.Location = new Point(ClientSize.Width - 615, ClientSize.Height - 254);


            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, 200);
            panelEsquerdo.Size = new Size(200, ClientSize.Height);

            // panelFundo.Location = new Point(ClientSize.Width / 2 - panelFundo.Size.Width / 2 + 100 , ClientSize.Height / 2 - panelFundo.Size.Height / 2 + 100);


            pictureBox1.Size = new Size(150, 150); // Defina o tamanho desejado para a PictureBox

            int deslocamentoHorizontal = 100; // Ajuste o deslocamento horizontal
            int deslocamentoVertical = 100;   // Ajuste o deslocamento vertical

            // Calcula a posição do painelMeio
            int xPainel = ClientSize.Width / 2 - panelFundo.Size.Width / 2;
            int yPainel = ClientSize.Height / 2 - panelFundo.Size.Height / 2;

            // Calcula a posição da PictureBox abaixo do painelMeio
            int xPictureBox = ClientSize.Width / 2 - pictureBox1.Size.Width / 2 + deslocamentoHorizontal;
            int yPictureBox = yPainel + panelFundo.Size.Height + deslocamentoVertical;

            pictureBox1.Location = new Point(xPictureBox, yPictureBox);



            this.Controls.Add(pictureBox1); // Adiciona a PictureBox ao formulário



        }

        public void carregaTela(Form form)
        {
            form.TopLevel = false;
            panelFundo.Controls.Clear();
            panelFundo.Controls.Add(form);
            // form.Location = new Point(panelFundo.Width,panelFundo.Height);
            form.Size = new Size(panelFundo.Width, panelFundo.Width);
            form.Show();
        }







        private void btnCancelar_Click(object sender, EventArgs e)
        {  
            painelMeio.Visible = false;
            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panelCima.Location = new Point(0, 0);
            HealtHub healtHub = new HealtHub();
            healtHub.TopLevel = false;
            panelCima.Controls.Add(healtHub);
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
            panelCima.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panelCima.Location = new Point(0, 0);
            bancosangue.TopLevel = false;
            panelCima.Controls.Add(bancosangue);
            bancosangue.Show();






        }

        private void btnVacina_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panelCima.Location = new Point(0, 0);
            Vacinacao vacinacao = new Vacinacao();
            vacinacao.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;
            };
            vacinacao.TopLevel = false;
            panelCima.Controls.Add(vacinacao);
            vacinacao.Show();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panelCima.Location = new Point(0, 0);
            ColetaExame coletaExame = new ColetaExame();
            coletaExame.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;
            };
            coletaExame.TopLevel = false;
            panelCima.Controls.Add(coletaExame);
            coletaExame.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            painelMeio.Visible = false;
            panel2.Visible = false;
            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panelCima.Location = new Point(0, 0);
            Consulta consulta = new Consulta();
            consulta.FormClosed += (s, args) =>
            {
                // Torna o painelMeio visível novamente quando o formulário Bancosangue for fechado
                painelMeio.Visible = true;

            };
            consulta.TopLevel = false;
            panelCima.Controls.Add(consulta);
            consulta.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
