namespace pi_Serasa_Projeto_Saude_lnwk
{
    internal static class Program
    {

        public static Atendente atendente = new Atendente();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HealtHub());
        }
    }
}