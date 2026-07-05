namespace Car_Shop
{
    partial class FormVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVeiculos));
            grbGerenciamentoVeiculo = new GroupBox();
            textBox9 = new TextBox();
            txtCor = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtPlaca = new TextBox();
            lbStatus = new Label();
            lbPreco = new Label();
            lbFoto = new Label();
            lbQuilometragem = new Label();
            lbCor = new Label();
            lbAno = new Label();
            lbMarca = new Label();
            lbModelo = new Label();
            lbPlaca = new Label();
            dataGridView1 = new DataGridView();
            btnVoltarTelaAdministrativa = new Button();
            btnVisualizarVeiculo = new Button();
            btnAtualizarVeiculo = new Button();
            btnListagemVeiculo = new Button();
            btnSalvarVeiculo = new Button();
            btnCadastrarVeiculo = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            grbGerenciamentoVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbGerenciamentoVeiculo
            // 
            grbGerenciamentoVeiculo.Controls.Add(textBox3);
            grbGerenciamentoVeiculo.Controls.Add(textBox2);
            grbGerenciamentoVeiculo.Controls.Add(textBox1);
            grbGerenciamentoVeiculo.Controls.Add(textBox9);
            grbGerenciamentoVeiculo.Controls.Add(txtCor);
            grbGerenciamentoVeiculo.Controls.Add(txtMarca);
            grbGerenciamentoVeiculo.Controls.Add(txtModelo);
            grbGerenciamentoVeiculo.Controls.Add(txtPlaca);
            grbGerenciamentoVeiculo.Controls.Add(lbStatus);
            grbGerenciamentoVeiculo.Controls.Add(lbPreco);
            grbGerenciamentoVeiculo.Controls.Add(lbFoto);
            grbGerenciamentoVeiculo.Controls.Add(lbQuilometragem);
            grbGerenciamentoVeiculo.Controls.Add(lbCor);
            grbGerenciamentoVeiculo.Controls.Add(lbAno);
            grbGerenciamentoVeiculo.Controls.Add(lbMarca);
            grbGerenciamentoVeiculo.Controls.Add(lbModelo);
            grbGerenciamentoVeiculo.Controls.Add(lbPlaca);
            grbGerenciamentoVeiculo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            grbGerenciamentoVeiculo.Location = new Point(10, 3);
            grbGerenciamentoVeiculo.Name = "grbGerenciamentoVeiculo";
            grbGerenciamentoVeiculo.Size = new Size(696, 439);
            grbGerenciamentoVeiculo.TabIndex = 0;
            grbGerenciamentoVeiculo.TabStop = false;
            grbGerenciamentoVeiculo.Text = "Gerenciamento de Veiculos";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(66, 393);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 30);
            textBox9.TabIndex = 17;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(69, 208);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 30);
            txtCor.TabIndex = 12;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(66, 172);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 30);
            txtMarca.TabIndex = 11;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(80, 73);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(80, 30);
            txtModelo.TabIndex = 10;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(66, 30);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 30);
            txtPlaca.TabIndex = 9;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(6, 396);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(61, 23);
            lbStatus.TabIndex = 8;
            lbStatus.Text = "Status:";
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(6, 351);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(57, 23);
            lbPreco.TabIndex = 7;
            lbPreco.Text = "Preço:";
            // 
            // lbFoto
            // 
            lbFoto.AutoSize = true;
            lbFoto.Location = new Point(6, 305);
            lbFoto.Name = "lbFoto";
            lbFoto.Size = new Size(49, 23);
            lbFoto.TabIndex = 6;
            lbFoto.Text = "Foto:";
            // 
            // lbQuilometragem
            // 
            lbQuilometragem.AutoSize = true;
            lbQuilometragem.Location = new Point(6, 259);
            lbQuilometragem.Name = "lbQuilometragem";
            lbQuilometragem.Size = new Size(134, 23);
            lbQuilometragem.TabIndex = 5;
            lbQuilometragem.Text = "Quilometragem:";
            // 
            // lbCor
            // 
            lbCor.AutoSize = true;
            lbCor.Location = new Point(6, 215);
            lbCor.Name = "lbCor";
            lbCor.Size = new Size(42, 23);
            lbCor.TabIndex = 4;
            lbCor.Text = "Cor:";
            // 
            // lbAno
            // 
            lbAno.AutoSize = true;
            lbAno.Location = new Point(6, 170);
            lbAno.Name = "lbAno";
            lbAno.Size = new Size(45, 23);
            lbAno.TabIndex = 3;
            lbAno.Text = "Ano:";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(6, 125);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(62, 23);
            lbMarca.TabIndex = 2;
            lbMarca.Text = "Marca:";
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Location = new Point(6, 80);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(73, 23);
            lbModelo.TabIndex = 1;
            lbModelo.Text = "Modelo:";
            // 
            // lbPlaca
            // 
            lbPlaca.AutoSize = true;
            lbPlaca.Location = new Point(6, 37);
            lbPlaca.Name = "lbPlaca";
            lbPlaca.Size = new Size(54, 23);
            lbPlaca.TabIndex = 0;
            lbPlaca.Text = "Placa:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(712, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(460, 687);
            dataGridView1.TabIndex = 1;
            // 
            // btnVoltarTelaAdministrativa
            // 
            btnVoltarTelaAdministrativa.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoltarTelaAdministrativa.Location = new Point(467, 590);
            btnVoltarTelaAdministrativa.Name = "btnVoltarTelaAdministrativa";
            btnVoltarTelaAdministrativa.Size = new Size(169, 93);
            btnVoltarTelaAdministrativa.TabIndex = 21;
            btnVoltarTelaAdministrativa.Text = "Voltar para tela adminstrativa";
            btnVoltarTelaAdministrativa.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarVeiculo
            // 
            btnVisualizarVeiculo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVisualizarVeiculo.Location = new Point(467, 480);
            btnVisualizarVeiculo.Name = "btnVisualizarVeiculo";
            btnVisualizarVeiculo.Size = new Size(169, 95);
            btnVisualizarVeiculo.TabIndex = 20;
            btnVisualizarVeiculo.Text = "Veiculo Visualizar";
            btnVisualizarVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarVeiculo
            // 
            btnAtualizarVeiculo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtualizarVeiculo.Location = new Point(263, 588);
            btnAtualizarVeiculo.Name = "btnAtualizarVeiculo";
            btnAtualizarVeiculo.Size = new Size(166, 95);
            btnAtualizarVeiculo.TabIndex = 19;
            btnAtualizarVeiculo.Text = "Veiculo Atualizar";
            btnAtualizarVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnListagemVeiculo
            // 
            btnListagemVeiculo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListagemVeiculo.Location = new Point(263, 480);
            btnListagemVeiculo.Name = "btnListagemVeiculo";
            btnListagemVeiculo.Size = new Size(166, 95);
            btnListagemVeiculo.TabIndex = 18;
            btnListagemVeiculo.Text = "Veiculo Listagem";
            btnListagemVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarVeiculo
            // 
            btnSalvarVeiculo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalvarVeiculo.Location = new Point(47, 588);
            btnSalvarVeiculo.Name = "btnSalvarVeiculo";
            btnSalvarVeiculo.Size = new Size(158, 95);
            btnSalvarVeiculo.TabIndex = 17;
            btnSalvarVeiculo.Text = "Veiculo Salvar";
            btnSalvarVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarVeiculo
            // 
            btnCadastrarVeiculo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCadastrarVeiculo.Location = new Point(47, 480);
            btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            btnCadastrarVeiculo.Size = new Size(158, 95);
            btnCadastrarVeiculo.TabIndex = 16;
            btnCadastrarVeiculo.Text = "Veiculo Cadastrar";
            btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 30);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 30);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 30);
            textBox3.TabIndex = 20;
            // 
            // FormVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(btnVoltarTelaAdministrativa);
            Controls.Add(btnVisualizarVeiculo);
            Controls.Add(btnAtualizarVeiculo);
            Controls.Add(btnListagemVeiculo);
            Controls.Add(btnSalvarVeiculo);
            Controls.Add(btnCadastrarVeiculo);
            Controls.Add(dataGridView1);
            Controls.Add(grbGerenciamentoVeiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVeiculos";
            Text = "FormVeiculos";
            grbGerenciamentoVeiculo.ResumeLayout(false);
            grbGerenciamentoVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbGerenciamentoVeiculo;
        private DataGridView dataGridView1;
        private Label lbStatus;
        private Label lbPreco;
        private Label lbFoto;
        private Label lbQuilometragem;
        private Label lbCor;
        private Label lbAno;
        private Label lbMarca;
        private Label lbModelo;
        private Label lbPlaca;
        private Button btnVoltarTelaAdministrativa;
        private Button btnVisualizarVeiculo;
        private Button btnAtualizarVeiculo;
        private Button btnListagemVeiculo;
        private Button btnSalvarVeiculo;
        private Button btnCadastrarVeiculo;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private TextBox textBox9;
        private TextBox txtCor;
        private TextBox txtMarca;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}