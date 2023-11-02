namespace Chronos.Avaliacao.Avaliacao.Agendamento
{
    partial class frmAgendamento
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
            panel2 = new Panel();
            txtMensagem = new RichTextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtHora = new MaskedTextBox();
            txtData = new DateTimePicker();
            cbmCliente = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            btnSair = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridAgendamento).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridAgendamento
            // 
            gridAgendamento.BackgroundColor = Color.White;
            gridAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAgendamento.Dock = DockStyle.Fill;
            gridAgendamento.Location = new Point(0, 236);
            gridAgendamento.Name = "gridAgendamento";
            gridAgendamento.RowHeadersWidth = 51;
            gridAgendamento.RowTemplate.Height = 29;
            gridAgendamento.Size = new Size(800, 214);
            gridAgendamento.TabIndex = 8;
            gridAgendamento.CellDoubleClick += gridAgendamento_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMensagem);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtHora);
            panel2.Controls.Add(txtData);
            panel2.Controls.Add(cbmCliente);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 168);
            panel2.TabIndex = 7;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(404, 47);
            txtMensagem.MaxLength = 150;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(384, 115);
            txtMensagem.TabIndex = 20;
            txtMensagem.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 47);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 19;
            label4.Text = "Mensagem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 43);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 18;
            label2.Text = "Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 43);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 17;
            label1.Text = "Hora";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(250, 40);
            txtHora.Mask = "00:00";
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(60, 27);
            txtHora.TabIndex = 16;
            txtHora.ValidatingType = typeof(DateTime);
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Custom;
            txtData.Location = new Point(74, 38);
            txtData.Name = "txtData";
            txtData.Size = new Size(122, 27);
            txtData.TabIndex = 15;
            // 
            // cbmCliente
            // 
            cbmCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbmCliente.FormattingEnabled = true;
            cbmCliente.Items.AddRange(new object[] { "Avaliador", "Gerente" });
            cbmCliente.Location = new Point(74, 6);
            cbmCliente.Name = "cbmCliente";
            cbmCliente.Size = new Size(714, 28);
            cbmCliente.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 13;
            label3.Text = "Cliente";
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
            panel1.TabIndex = 6;
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
            btnEditar.Click += btnEditar_Click;
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
            // frmAgendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridAgendamento);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAgendamento";
            Text = "Agendamentos";
            Load += frmAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)gridAgendamento).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridAgendamento;
        private Panel panel2;
        private ComboBox cbmCliente;
        private Label label3;
        private Panel panel1;
        private Button btnSair;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private DateTimePicker txtData;
        private MaskedTextBox txtHora;
        private Label label1;
        private RichTextBox txtMensagem;
        private Label label4;
        private Label label2;
    }
}