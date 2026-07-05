namespace Car_Shop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Use a custom ApplicationContext to allow switching the main form
            Application.Run(new AppContextCustom());
        }
    }

    // ApplicationContext que controla a troca entre telas (login -> administrador)
    internal class AppContextCustom : ApplicationContext
    {
        private Form1 loginForm;

        public AppContextCustom()
        {
            loginForm = new Form1();
            // Assina o evento que o Form1 dispara quando o login for bem-sucedido
            loginForm.LoginSucceeded += OnLoginSucceeded;
            // Define o MainForm atual como o formulário de login
            MainForm = loginForm;
            loginForm.Show();
        }

        private void OnLoginSucceeded(object? sender, EventArgs e)
        {
            // Cria a tela de administrador e a torna o MainForm
            FormTelaAdministrador admin = new FormTelaAdministrador();

            // Remove a inscrição para evitar múltiplos handlers
            if (loginForm != null)
            {
                loginForm.LoginSucceeded -= OnLoginSucceeded;
            }

            // Define o novo MainForm antes de fechar o antigo
            MainForm = admin;
            admin.Show();

            // Fecha o login (agora que admin é MainForm, a aplicação continua)
            loginForm?.Close();
            loginForm = null;
        }
    }
}