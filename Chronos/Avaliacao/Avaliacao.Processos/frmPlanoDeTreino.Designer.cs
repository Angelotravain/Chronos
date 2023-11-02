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
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.Location = new Point(182, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 68);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnGerarAvaliacao
            // 
            btnGerarAvaliacao.Dock = DockStyle.Left;
            btnGerarAvaliacao.Location = new Point(0, 0);
            btnGerarAvaliacao.Name = "btnGerarAvaliacao";
            btnGerarAvaliacao.Size = new Size(182, 68);
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
            gridExercicios.Location = new Point(0, 196);
            gridExercicios.Name = "gridExercicios";
            gridExercicios.ReadOnly = true;
            gridExercicios.RowHeadersWidth = 51;
            gridExercicios.RowTemplate.Height = 29;
            gridExercicios.Size = new Size(459, 254);
            gridExercicios.TabIndex = 8;
            gridExercicios.CellDoubleClick += gridExercicios_CellDoubleClick;
            // 
            // gridTreino
            // 
            gridTreino.BackgroundColor = Color.White;
            gridTreino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTreino.Dock = DockStyle.Right;
            gridTreino.Location = new Point(459, 68);
            gridTreino.Name = "gridTreino";
            gridTreino.RowHeadersWidth = 51;
            gridTreino.RowTemplate.Height = 29;
            gridTreino.Size = new Size(341, 382);
            gridTreino.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdicionarExercicio);
            panel2.Controls.Add(txtRepeticoes);
            panel2.Controls.Add(txtSeries);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtExercicio);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 128);
            panel2.TabIndex = 10;
            // 
            // btnAdicionarExercicio
            // 
            btnAdicionarExercicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarExercicio.Location = new Point(282, 72);
            btnAdicionarExercicio.Name = "btnAdicionarExercicio";
            btnAdicionarExercicio.Size = new Size(171, 50);
            btnAdicionarExercicio.TabIndex = 28;
            btnAdicionarExercicio.Text = "Adicionar >";
            btnAdicionarExercicio.UseVisualStyleBackColor = true;
            btnAdicionarExercicio.Click += btnAdicionarExercicio_Click;
            // 
            // txtRepeticoes
            // 
            txtRepeticoes.Location = new Point(282, 39);
            txtRepeticoes.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            txtRepeticoes.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            txtRepeticoes.Name = "txtRepeticoes";
            txtRepeticoes.Size = new Size(171, 27);
            txtRepeticoes.TabIndex = 27;
            txtRepeticoes.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // txtSeries
            // 
            txtSeries.Location = new Point(57, 41);
            txtSeries.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            txtSeries.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSeries.Name = "txtSeries";
            txtSeries.Size = new Size(131, 27);
            txtSeries.TabIndex = 26;
            txtSeries.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 41);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 25;
            label5.Text = "Repetições";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 24;
            label4.Text = "Séries";
            // 
            // txtExercicio
            // 
            txtExercicio.Location = new Point(75, 6);
            txtExercicio.Name = "txtExercicio";
            txtExercicio.Size = new Size(378, 27);
            txtExercicio.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 13);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 18;
            label1.Text = "Exercício";
            // 
            // frmPlanoDeTreino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(gridExercicios);
            Controls.Add(gridTreino);
            Controls.Add(panel1);
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
    }
}