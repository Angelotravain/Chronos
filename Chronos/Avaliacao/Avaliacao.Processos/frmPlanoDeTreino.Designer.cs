namespace Chronos.Avaliacao.Avaliacao.Processos
{
    partial class frmPlanoDeTreino
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
            btnGerarAvaliacao = new Button();
            gridExercicios = new DataGridView();
            gridTreino = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            cbmCliente = new ComboBox();
            btnAdicionarExercicio = new Button();
            txtRepeticoes = new NumericUpDown();
            txtSeries = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            txtExercicio = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridExercicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridTreino).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtRepeticoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSeries).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnGerarAvaliacao);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 51);
            panel1.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.Location = new Point(159, 0);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(82, 51);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnGerarAvaliacao
            // 
            btnGerarAvaliacao.Dock = DockStyle.Left;
            btnGerarAvaliacao.Location = new Point(0, 0);
            btnGerarAvaliacao.Margin = new Padding(3, 2, 3, 2);
            btnGerarAvaliacao.Name = "btnGerarAvaliacao";
            btnGerarAvaliacao.Size = new Size(159, 51);
            btnGerarAvaliacao.TabIndex = 1;
            btnGerarAvaliacao.Text = "Gerar plano de treino";
            btnGerarAvaliacao.UseVisualStyleBackColor = true;
            btnGerarAvaliacao.Click += btnGerarAvaliacao_Click;
            // 
            // gridExercicios
            // 
            gridExercicios.AllowUserToAddRows = false;
            gridExercicios.AllowUserToDeleteRows = false;
            gridExercicios.AllowUserToOrderColumns = true;
            gridExercicios.BackgroundColor = Color.White;
            gridExercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridExercicios.Dock = DockStyle.Bottom;
            gridExercicios.Location = new Point(0, 186);
            gridExercicios.Margin = new Padding(3, 2, 3, 2);
            gridExercicios.Name = "gridExercicios";
            gridExercicios.ReadOnly = true;
            gridExercicios.RowHeadersWidth = 51;
            gridExercicios.RowTemplate.Height = 29;
            gridExercicios.Size = new Size(402, 152);
            gridExercicios.TabIndex = 8;
            gridExercicios.CellDoubleClick += gridExercicios_CellDoubleClick;
            // 
            // gridTreino
            // 
            gridTreino.BackgroundColor = Color.White;
            gridTreino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTreino.Dock = DockStyle.Right;
            gridTreino.Location = new Point(402, 51);
            gridTreino.Margin = new Padding(3, 2, 3, 2);
            gridTreino.Name = "gridTreino";
            gridTreino.RowHeadersWidth = 51;
            gridTreino.RowTemplate.Height = 29;
            gridTreino.Size = new Size(298, 287);
            gridTreino.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbmCliente);
            panel2.Controls.Add(btnAdicionarExercicio);
            panel2.Controls.Add(txtRepeticoes);
            panel2.Controls.Add(txtSeries);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtExercicio);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 51);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 135);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 30;
            label2.Text = "Cliente";
            // 
            // cbmCliente
            // 
            cbmCliente.FormattingEnabled = true;
            cbmCliente.Location = new Point(62, 5);
            cbmCliente.Name = "cbmCliente";
            cbmCliente.Size = new Size(334, 23);
            cbmCliente.TabIndex = 29;
            // 
            // btnAdicionarExercicio
            // 
            btnAdicionarExercicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarExercicio.Location = new Point(246, 88);
            btnAdicionarExercicio.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarExercicio.Name = "btnAdicionarExercicio";
            btnAdicionarExercicio.Size = new Size(150, 38);
            btnAdicionarExercicio.TabIndex = 28;
            btnAdicionarExercicio.Text = "Adicionar >";
            btnAdicionarExercicio.UseVisualStyleBackColor = true;
            btnAdicionarExercicio.Click += btnAdicionarExercicio_Click;
            // 
            // txtRepeticoes
            // 
            txtRepeticoes.Location = new Point(246, 63);
            txtRepeticoes.Margin = new Padding(3, 2, 3, 2);
            txtRepeticoes.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            txtRepeticoes.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            txtRepeticoes.Name = "txtRepeticoes";
            txtRepeticoes.Size = new Size(150, 23);
            txtRepeticoes.TabIndex = 27;
            txtRepeticoes.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // txtSeries
            // 
            txtSeries.Location = new Point(49, 65);
            txtSeries.Margin = new Padding(3, 2, 3, 2);
            txtSeries.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            txtSeries.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSeries.Name = "txtSeries";
            txtSeries.Size = new Size(115, 23);
            txtSeries.TabIndex = 26;
            txtSeries.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 65);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 25;
            label5.Text = "Repetições";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 65);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 24;
            label4.Text = "Séries";
            // 
            // txtExercicio
            // 
            txtExercicio.Enabled = false;
            txtExercicio.Location = new Point(65, 38);
            txtExercicio.Margin = new Padding(3, 2, 3, 2);
            txtExercicio.Name = "txtExercicio";
            txtExercicio.Size = new Size(331, 23);
            txtExercicio.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Exercício";
            // 
            // frmPlanoDeTreino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(gridExercicios);
            Controls.Add(gridTreino);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPlanoDeTreino";
            Text = "Montagem plano de treino";
            Load += frmPlanoDeTreino_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridExercicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridTreino).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtRepeticoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSeries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSair;
        private Button btnGerarAvaliacao;
        private DataGridView gridExercicios;
        private DataGridView gridTreino;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button btnAdicionarExercicio;
        private NumericUpDown txtRepeticoes;
        private NumericUpDown txtSeries;
        private TextBox txtExercicio;
        private Label label2;
        private ComboBox cbmCliente;
    }
}