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
            WindowState= FormWindowState.Maximized;


           
            panel1.Size = new Size(ClientSize.Width, 200);

            panel2.Location = new Point(ClientSize.Width / 2 - panel2.Size.Width / 2, ClientSize.Height / 2 - panel2.Size.Height / 2);

            label1.Location = new Point(panel1.Width / 2 - label1.Size.Width / 2); //centralizar o label no panel

            panel2.Size = new Size(ClientSize.Height, 200);


            panel3.Size = new Size (ClientSize.Width,200);

            



        }
    }





}

