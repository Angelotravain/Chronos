using Chronos.Avaliacao.DTO.Cadastros;

namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    partial class frmClientes
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
            panel1 = new Panel();
            btnSair = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            panel2 = new Panel();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEndereco = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDataNascimento = new DateTimePicker();
            txtSobrenome = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            gridCliente = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.Location = new Point(282, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 68);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Dock = DockStyle.Left;
            btnExcluir.Location = new Point(188, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 68);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Left;
            btnEditar.Location = new Point(94, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 68);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Left;
            btnSalvar.Location = new Point(0, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 68);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTelefone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtEndereco);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDataNascimento);
            panel2.Controls.Add(txtSobrenome);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 120);
            panel2.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(74, 68);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(204, 27);
            txtTelefone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(353, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(435, 27);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 71);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 10;
            label6.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 72);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefone";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(376, 39);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(412, 27);
            txtEndereco.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 39);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 5;
            label3.Text = "Data de nascimento";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Format = DateTimePickerFormat.Short;
            txtDataNascimento.Location = new Point(151, 36);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(127, 27);
            txtDataNascimento.TabIndex = 4;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(353, 6);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(435, 27);
            txtSobrenome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 6);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Sobrenome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(59, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(193, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // gridCliente
            // 
            gridCliente.BackgroundColor = Color.White;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Dock = DockStyle.Fill;
            gridCliente.Location = new Point(0, 188);
            gridCliente.Name = "gridCliente";
            gridCliente.RowHeadersWidth = 51;
            gridCliente.RowTemplate.Height = 29;
            gridCliente.Size = new Size(800, 262);
            gridCliente.TabIndex = 2;
            gridCliente.CellDoubleClick += gridCliente_CellDoubleClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridCliente);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            ResumeLayout(false);
        }
        private void PreencherCamposComCliente(ClienteDTO? clienteRecuperado)
        {
            txtNome.Text = clienteRecuperado.Nome;
            txtSobrenome.Text = clienteRecuperado.Sobrenome;
            txtDataNascimento.Value = Convert.ToDateTime(clienteRecuperado.DataNascimento);
            txtEmail.Text = clienteRecuperado.Email;
            txtEndereco.Text = clienteRecuperado.Email;
            txtTelefone.Text = clienteRecuperado.NumeroTelefone;
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSair;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Label label3;
        private DateTimePicker txtDataNascimento;
        private TextBox txtSobrenome;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private TextBox txtEndereco;
        private Label label4;
        private MaskedTextBox txtTelefone;
        private DataGridView gridCliente;
    }
}