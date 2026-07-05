namespace Car_Shop
{
    partial class FormVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
            btnVoltarTelaAdministrativa = new Button();
            btnVisualizarVendedor = new Button();
            btnAtualizarVendedor = new Button();
            btnListagemVendedor = new Button();
            btnSalvarVendedor = new Button();
            btnCadastrarVendedor = new Button();
            dgvClientes = new DataGridView();
            gboxGerenciamentoCliente = new GroupBox();
            txtSenha = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            lbSenha = new Label();
            lbTelefone = new Label();
            lbEmail = new Label();
            lbCPF = new Label();
            lbNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gboxGerenciamentoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltarTelaAdministrativa
            // 
            btnVoltarTelaAdministrativa.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoltarTelaAdministrativa.Location = new Point(374, 464);
            btnVoltarTelaAdministrativa.Name = "btnVoltarTelaAdministrativa";
            btnVoltarTelaAdministrativa.Size = new Size(146, 70);
            btnVoltarTelaAdministrativa.TabIndex = 15;
            btnVoltarTelaAdministrativa.Text = "Voltar para tela adminstrativa";
            btnVoltarTelaAdministrativa.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarVendedor
            // 
            btnVisualizarVendedor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVisualizarVendedor.Location = new Point(374, 354);
            btnVisualizarVendedor.Name = "btnVisualizarVendedor";
            btnVisualizarVendedor.Size = new Size(146, 72);
            btnVisualizarVendedor.TabIndex = 14;
            btnVisualizarVendedor.Text = "Vendedor Visualizar";
            btnVisualizarVendedor.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarVendedor
            // 
            btnAtualizarVendedor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtualizarVendedor.Location = new Point(190, 462);
            btnAtualizarVendedor.Name = "btnAtualizarVendedor";
            btnAtualizarVendedor.Size = new Size(143, 72);
            btnAtualizarVendedor.TabIndex = 13;
            btnAtualizarVendedor.Text = "Vendedor Atualizar";
            btnAtualizarVendedor.UseVisualStyleBackColor = true;
            // 
            // btnListagemVendedor
            // 
            btnListagemVendedor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListagemVendedor.Location = new Point(190, 354);
            btnListagemVendedor.Name = "btnListagemVendedor";
            btnListagemVendedor.Size = new Size(143, 72);
            btnListagemVendedor.TabIndex = 12;
            btnListagemVendedor.Text = "Vendedor Listagem";
            btnListagemVendedor.UseVisualStyleBackColor = true;
            // 
            // btnSalvarVendedor
            // 
            btnSalvarVendedor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalvarVendedor.Location = new Point(20, 462);
            btnSalvarVendedor.Name = "btnSalvarVendedor";
            btnSalvarVendedor.Size = new Size(135, 72);
            btnSalvarVendedor.TabIndex = 11;
            btnSalvarVendedor.Text = "Vendedor Salvar";
            btnSalvarVendedor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarVendedor
            // 
            btnCadastrarVendedor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCadastrarVendedor.Location = new Point(20, 354);
            btnCadastrarVendedor.Name = "btnCadastrarVendedor";
            btnCadastrarVendedor.Size = new Size(135, 72);
            btnCadastrarVendedor.TabIndex = 10;
            btnCadastrarVendedor.Text = "Vendedor Cadastrar";
            btnCadastrarVendedor.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(601, 11);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(374, 523);
            dgvClientes.TabIndex = 9;
            // 
            // gboxGerenciamentoCliente
            // 
            gboxGerenciamentoCliente.Controls.Add(txtSenha);
            gboxGerenciamentoCliente.Controls.Add(txtTelefone);
            gboxGerenciamentoCliente.Controls.Add(txtEmail);
            gboxGerenciamentoCliente.Controls.Add(txtCPF);
            gboxGerenciamentoCliente.Controls.Add(txtNome);
            gboxGerenciamentoCliente.Controls.Add(lbSenha);
            gboxGerenciamentoCliente.Controls.Add(lbTelefone);
            gboxGerenciamentoCliente.Controls.Add(lbEmail);
            gboxGerenciamentoCliente.Controls.Add(lbCPF);
            gboxGerenciamentoCliente.Controls.Add(lbNome);
            gboxGerenciamentoCliente.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxGerenciamentoCliente.Location = new Point(11, 11);
            gboxGerenciamentoCliente.Name = "gboxGerenciamentoCliente";
            gboxGerenciamentoCliente.Size = new Size(584, 300);
            gboxGerenciamentoCliente.TabIndex = 8;
            gboxGerenciamentoCliente.TabStop = false;
            gboxGerenciamentoCliente.Text = "Gerenciamento de Vendedores";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(74, 242);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(435, 30);
            txtSenha.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(87, 187);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(422, 30);
            txtTelefone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(435, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(74, 85);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(435, 30);
            txtCPF.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(435, 30);
            txtNome.TabIndex = 5;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(9, 251);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(55, 20);
            lbSenha.TabIndex = 4;
            lbSenha.Text = "Senha:";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(9, 196);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(73, 20);
            lbTelefone.TabIndex = 3;
            lbTelefone.Text = "Telefone:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(9, 139);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email:";
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCPF.Location = new Point(9, 94);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(39, 20);
            lbCPF.TabIndex = 1;
            lbCPF.Text = "CPF:";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(9, 46);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(56, 20);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // FormVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 545);
            Controls.Add(btnVoltarTelaAdministrativa);
            Controls.Add(btnVisualizarVendedor);
            Controls.Add(btnAtualizarVendedor);
            Controls.Add(btnListagemVendedor);
            Controls.Add(btnSalvarVendedor);
            Controls.Add(btnCadastrarVendedor);
            Controls.Add(dgvClientes);
            Controls.Add(gboxGerenciamentoCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVendedor";
            Text = "FormVendedor";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gboxGerenciamentoCliente.ResumeLayout(false);
            gboxGerenciamentoCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltarTelaAdministrativa;
        private Button btnVisualizarVendedor;
        private Button btnAtualizarVendedor;
        private Button btnListagemVendedor;
        private Button btnSalvarVendedor;
        private Button btnCadastrarVendedor;
        private DataGridView dgvClientes;
        private GroupBox gboxGerenciamentoCliente;
        private TextBox txtSenha;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtNome;
        private Label lbSenha;
        private Label lbTelefone;
        private Label lbEmail;
        private Label lbCPF;
        private Label lbNome;
    }
}