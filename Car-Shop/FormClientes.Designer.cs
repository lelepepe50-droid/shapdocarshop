namespace Car_Shop
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            gboxGerenciamentoCliente = new GroupBox();
            lbNome = new Label();
            lbCPF = new Label();
            lbEmail = new Label();
            lbTelefone = new Label();
            lbSenha = new Label();
            dgvClientes = new DataGridView();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            btnCadastrarCliente = new Button();
            btnSalvarCliente = new Button();
            btnListagemCliente = new Button();
            btnAtualizarCliente = new Button();
            btnVisualizarCliente = new Button();
            btnVoltarTelaAdministrativa = new Button();
            gboxGerenciamentoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
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
            gboxGerenciamentoCliente.Location = new Point(11, 10);
            gboxGerenciamentoCliente.Name = "gboxGerenciamentoCliente";
            gboxGerenciamentoCliente.Size = new Size(584, 300);
            gboxGerenciamentoCliente.TabIndex = 0;
            gboxGerenciamentoCliente.TabStop = false;
            gboxGerenciamentoCliente.Text = "Gerenciamento de Clientes";
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
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(601, 10);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(374, 523);
            dgvClientes.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(435, 30);
            txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(74, 85);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(435, 30);
            txtCPF.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(435, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(87, 187);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(422, 30);
            txtTelefone.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(74, 242);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(435, 30);
            txtSenha.TabIndex = 9;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCadastrarCliente.Location = new Point(20, 353);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(135, 72);
            btnCadastrarCliente.TabIndex = 2;
            btnCadastrarCliente.Text = "Cliente Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCliente
            // 
            btnSalvarCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalvarCliente.Location = new Point(20, 461);
            btnSalvarCliente.Name = "btnSalvarCliente";
            btnSalvarCliente.Size = new Size(135, 72);
            btnSalvarCliente.TabIndex = 3;
            btnSalvarCliente.Text = "Cliente Salvar";
            btnSalvarCliente.UseVisualStyleBackColor = true;
            // 
            // btnListagemCliente
            // 
            btnListagemCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListagemCliente.Location = new Point(190, 353);
            btnListagemCliente.Name = "btnListagemCliente";
            btnListagemCliente.Size = new Size(143, 72);
            btnListagemCliente.TabIndex = 4;
            btnListagemCliente.Text = "Cliente Listagem";
            btnListagemCliente.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarCliente
            // 
            btnAtualizarCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtualizarCliente.Location = new Point(190, 461);
            btnAtualizarCliente.Name = "btnAtualizarCliente";
            btnAtualizarCliente.Size = new Size(143, 72);
            btnAtualizarCliente.TabIndex = 5;
            btnAtualizarCliente.Text = "Cliente Atualizar";
            btnAtualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarCliente
            // 
            btnVisualizarCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVisualizarCliente.Location = new Point(374, 353);
            btnVisualizarCliente.Name = "btnVisualizarCliente";
            btnVisualizarCliente.Size = new Size(146, 72);
            btnVisualizarCliente.TabIndex = 6;
            btnVisualizarCliente.Text = "Cliente Visualizar";
            btnVisualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTelaAdministrativa
            // 
            btnVoltarTelaAdministrativa.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoltarTelaAdministrativa.Location = new Point(374, 463);
            btnVoltarTelaAdministrativa.Name = "btnVoltarTelaAdministrativa";
            btnVoltarTelaAdministrativa.Size = new Size(146, 70);
            btnVoltarTelaAdministrativa.TabIndex = 7;
            btnVoltarTelaAdministrativa.Text = "Voltar para tela adminstrativa";
            btnVoltarTelaAdministrativa.UseVisualStyleBackColor = true;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 545);
            Controls.Add(btnVoltarTelaAdministrativa);
            Controls.Add(btnVisualizarCliente);
            Controls.Add(btnAtualizarCliente);
            Controls.Add(btnListagemCliente);
            Controls.Add(btnSalvarCliente);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(dgvClientes);
            Controls.Add(gboxGerenciamentoCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormClientes";
            Text = "FormClientes";
            gboxGerenciamentoCliente.ResumeLayout(false);
            gboxGerenciamentoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxGerenciamentoCliente;
        private Label lbCPF;
        private Label lbNome;
        private Label lbSenha;
        private Label lbTelefone;
        private Label lbEmail;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtNome;
        private DataGridView dgvClientes;
        private TextBox txtSenha;
        private TextBox txtTelefone;
        private Button btnCadastrarCliente;
        private Button btnSalvarCliente;
        private Button btnListagemCliente;
        private Button btnAtualizarCliente;
        private Button btnVisualizarCliente;
        private Button btnVoltarTelaAdministrativa;
    }
}