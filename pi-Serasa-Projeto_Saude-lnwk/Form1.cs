namespace pi_Serasa_Projeto_Saude_lnwk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            HealtHub healtHub = new HealtHub();
            healtHub.TopLevel = false;
            panel1.Controls.Add(healtHub);
            healtHub.Show();

            




        }
        public void btnEntrar_Click(object sender, EventArgs e)
        {
            RecepcaoAtendente recepcao = new RecepcaoAtendente();

            recepcao.Show();
        }


    }
}