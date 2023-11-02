namespace Chronos.Avaliacao.Avaliacao.Agendamento
{
    partial class frmAgendaentoDoDia
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
            gridAgendamento = new DataGridView();
            panel1 = new Panel();
            txtQuantidadeAgendamentos = new Label();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)gridAgendamento).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridAgendamento
            // 
            gridAgendamento.BackgroundColor = Color.White;
            gridAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAgendamento.Dock = DockStyle.Fill;
            gridAgendamento.Location = new Point(0, 68);
            gridAgendamento.Name = "gridAgendamento";
            gridAgendamento.RowHeadersWidth = 51;
            gridAgendamento.RowTemplate.Height = 29;
            gridAgendamento.Size = new Size(800, 382);
            gridAgendamento.TabIndex = 10;
            gridAgendamento.CellContentClick += gridAgendamento_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtQuantidadeAgendamentos);
            panel1.Controls.Add(btnSair);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 9;
            // 
            // txtQuantidadeAgendamentos
            // 
            txtQuantidadeAgendamentos.AutoSize = true;
            txtQuantidadeAgendamentos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantidadeAgendamentos.Location = new Point(358, 9);
            txtQuantidadeAgendamentos.Name = "txtQuantidadeAgendamentos";
            txtQuantidadeAgendamentos.Size = new Size(446, 31);
            txtQuantidadeAgendamentos.TabIndex = 7;
            txtQuantidadeAgendamentos.Text = "Quantidade de agendamentos do dia: 00";
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 68);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmAgendaentoDoDia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridAgendamento);
            Controls.Add(panel1);
            Name = "frmAgendaentoDoDia";
            Text = "Agendamentos do dia";
            Load += frmAgendaentoDoDia_Load;
            ((System.ComponentModel.ISupportInitialize)gridAgendamento).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridAgendamento;
        private Panel panel1;
        private Button btnSair;
        private Button btnSalvar;
        private Label txtQuantidadeAgendamentos;
    }
}