namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    partial class frmRelatorioCliente
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
            gridRelatorioCliente = new DataGridView();
            panel1 = new Panel();
            txtQuantidadeClientes = new Label();
            btnSair = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridRelatorioCliente).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridRelatorioCliente
            // 
            gridRelatorioCliente.BackgroundColor = Color.White;
            gridRelatorioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRelatorioCliente.Dock = DockStyle.Fill;
            gridRelatorioCliente.Location = new Point(0, 68);
            gridRelatorioCliente.Name = "gridRelatorioCliente";
            gridRelatorioCliente.RowHeadersWidth = 51;
            gridRelatorioCliente.RowTemplate.Height = 29;
            gridRelatorioCliente.Size = new Size(800, 382);
            gridRelatorioCliente.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtQuantidadeClientes);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 11;
            // 
            // txtQuantidadeClientes
            // 
            txtQuantidadeClientes.AutoSize = true;
            txtQuantidadeClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantidadeClientes.Location = new Point(315, 9);
            txtQuantidadeClientes.Name = "txtQuantidadeClientes";
            txtQuantidadeClientes.Size = new Size(430, 31);
            txtQuantidadeClientes.TabIndex = 6;
            txtQuantidadeClientes.Text = "Quantidade de clientes cadastrados: 00";
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.Location = new Point(128, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 68);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Dock = DockStyle.Left;
            btnSalvar.ForeColor = SystemColors.ControlText;
            btnSalvar.Location = new Point(0, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(128, 68);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Visualizar PDF";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmRelatorioCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridRelatorioCliente);
            Controls.Add(panel1);
            Name = "frmRelatorioCliente";
            Text = "Relatório clientes";
            Load += frmRelatorioCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gridRelatorioCliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridRelatorioCliente;
        private Panel panel1;
        private Button btnSair;
        private Button btnSalvar;
        private Label txtQuantidadeClientes;
    }
}