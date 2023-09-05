using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_Serasa_Projeto_Saude_lnwk
{
    public partial class Bancosangue : Form
    {


        



        private Panel panel;
        public Bancosangue()
        {
            InitializeComponent();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.BackColor = System.Drawing.Color.Red;
            panel.Dock = DockStyle.Top;
            panel.Height = 100;

            Controls.Add(panel);

            KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                ToggleFullScreenMode();
            }
        }

        private void ToggleFullScreenMode()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                panel.Dock = DockStyle.Top;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                panel.Dock = DockStyle.None;
                panel.Height = 0;
            }
        }

        private void Bancosangue_Load(object sender, EventArgs e)
        {


            WindowState = FormWindowState.Maximized;



            // Configurar a ancoragem dos controles para se adaptarem automaticamente ao redimensionamento
            panel1.Dock = DockStyle.Top;
            panel2.Size = new Size(300, 200); // Defina o tamanho desejado para o panel2
            panel2.Location = new Point((ClientSize.Width - panel2.Width) / 2, (ClientSize.Height - panel2.Height) / 2);
            pictureBox1.Dock = DockStyle.Bottom;

            // Criar um TableLayoutPanel dentro do panel1
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            panel1.Controls.Add(tableLayoutPanel);

            // Adicione o label1 ao TableLayoutPanel e centralize-o
            label1.AutoSize = true;
            label1.Anchor = AnchorStyles.None;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel.Controls.Add(label1, 0, 0);

            // Posicione as imagens (pictureBox2 e pictureBox3) conforme necessário
            int offsetX = 500;
            pictureBox2.Location = new Point(ClientSize.Width / 2 - pictureBox2.Width / 2 + offsetX, ClientSize.Height / 2 - pictureBox2.Height / 2 + 200);
            pictureBox3.Location = new Point(offsetX, ClientSize.Height / 2 - pictureBox3.Height / 2 + 200);

            // Adicione um manipulador de evento para SizeChanged do panel1
            panel1.SizeChanged += Panel1_SizeChanged;
        }

        private void Panel1_SizeChanged(object sender, EventArgs e)
        {
            // Redimensionar o TableLayoutPanel para se ajustar automaticamente ao tamanho do panel1
            ((TableLayoutPanel)panel1.Controls[0]).Size = panel1.Size;























        }

        private void btnDoarSangue_Click(object sender, EventArgs e)
        {

        }
    }





}

