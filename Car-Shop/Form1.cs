using Microsoft.Data.SqlClient;
// 🔄 Mudamos a biblioteca para focar no MySQL
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Car_Shop
{
    public partial class Form1 : Form
    {
        // ⚠️ Ajuste o 'Uid' (Usuário) e 'Pwd' (Senha) de acordo com o que você configurou no DBeaver.
        // O padrão geralmente é Uid=root e Pwd= (vazio) ou a senha que você criou na instalação.
        private string stringConexao = "Server=localhost;Database=db_carros_projeto_integrador;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar; // Permite logar apertando ENTER

            // Garantir textos em tempo de execução (evita rótulos vazios ou nomes padrão)
            lbTelaDeConsultas.Text = "Tela de Login Administrativo";
            lbCarShop.Text = "Car Shop";
            lbEmail.Text = "Email:";
            lbSenha.Text = "Senha:";
            btnEntrar.Text = "Entrar";
            btnSair.Text = "Sair";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string emailDigitado = txtEmail.Text;
            string senhaDigitada = txtSenha.Text;

            if (string.IsNullOrEmpty(emailDigitado) || string.IsNullOrEmpty(senhaDigitada))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usando as classes do MySQL agora (MySqlConnection)
            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                // Query apontando para sua tabela tb_admin
                string query = "SELECT COUNT(1) FROM tb_admin WHERE email = @Email AND senha = @Senha";

                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Email", emailDigitado);
                    comando.Parameters.AddWithValue("@Senha", senhaDigitada);

                    try
                    {
                        conexao.Open();

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());

                        if (resultado > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abre a tela que você quer
                            FormTelaAdministrador telaAdmin = new FormTelaAdministrador();

                            this.Hide();
                            telaAdmin.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco MySQL: " + ex.Message, "Erro Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Mantido para compatibilidade futura; pode validar o email aqui se desejar
        }
    }
}