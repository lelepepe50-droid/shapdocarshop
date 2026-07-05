using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Shop
{
    public partial class FormTelaAdministrador : Form
    {
        public FormTelaAdministrador()
        {
            InitializeComponent();

            // Forçar textos em tempo de execução (garante que os rótulos/botões não exibam nomes padrão)
            label1.Text = "Bem-Vindo a Tela de Administração do Car Shop";
            label2.Text = "Clique nos Botões para Entrar nas Outras Páginas";
            btnGerenciamentoCliente.Text = "Gerenciamento de Clientes";
            btnGerenciamentoVendedor.Text = "Gerenciamento de Vendedores";
            btnGerenciamentoVeiculos.Text = "Gerenciamento de Veículos";
            btnEncerreSessao.Text = "Encerre a Sessão";
        }

        private void btnGerenciamentoCliente_Click(object sender, EventArgs e)
        {
            // Abrir formulário de clientes como diálogo modal
            using (FormClientes frm = new FormClientes())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void btnGerenciamentoVendedor_Click(object sender, EventArgs e)
        {
            // Abrir formulário de vendedores como diálogo modal
            using (FormVendedor frm = new FormVendedor())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void btnGerenciamentoVeiculos_Click(object sender, EventArgs e)
        {
            // Abrir formulário de veículos como diálogo modal
            using (FormVeiculos frm = new FormVeiculos())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void btnEncerreSessao_Click(object sender, EventArgs e)
        {
            // Fecha a tela de administrador — se vier de um login que ficou oculto, o login será exibido novamente
            this.Close();
        }
    }
}
