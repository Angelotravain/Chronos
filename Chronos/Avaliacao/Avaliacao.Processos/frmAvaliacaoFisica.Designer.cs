namespace Chronos.Avaliacao.Avaliacao.Processos
{
    partial class frmAvaliacaoFisica
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
            panel2 = new Panel();
            label8 = new Label();
            txtObjetivo = new RichTextBox();
            label7 = new Label();
            txtCircSupra = new NumericUpDown();
            label6 = new Label();
            txtCircTtriceps = new NumericUpDown();
            txtCircAbdominal = new NumericUpDown();
            label5 = new Label();
            txtAltura = new NumericUpDown();
            label4 = new Label();
            txtPeso = new NumericUpDown();
            label3 = new Label();
            txtData = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnSair = new Button();
            btnGerarAvaliacao = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCircSupra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCircTtriceps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCircAbdominal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPeso).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtObjetivo);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtCircSupra);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCircTtriceps);
            panel2.Controls.Add(txtCircAbdominal);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAltura);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPeso);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtData);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 382);
            panel2.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 102);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 15;
            label8.Text = "Objetivos";
            // 
            // txtObjetivo
            // 
            txtObjetivo.Location = new Point(12, 125);
            txtObjetivo.MaxLength = 400;
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.Size = new Size(425, 245);
            txtObjetivo.TabIndex = 14;
            txtObjetivo.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 130);
            label7.Name = "label7";
            label7.Size = new Size(178, 20);
            label7.TabIndex = 13;
            label7.Text = "Circunferência supraíliaca";
            // 
            // txtCircSupra
            // 
            txtCircSupra.DecimalPlaces = 2;
            txtCircSupra.Location = new Point(647, 128);
            txtCircSupra.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            txtCircSupra.Name = "txtCircSupra";
            txtCircSupra.Size = new Size(150, 27);
            txtCircSupra.TabIndex = 12;
            txtCircSupra.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 97);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 11;
            label6.Text = "Circunferência tríceps";
            // 
            // txtCircTtriceps
            // 
            txtCircTtriceps.DecimalPlaces = 2;
            txtCircTtriceps.Location = new Point(647, 95);
            txtCircTtriceps.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            txtCircTtriceps.Name = "txtCircTtriceps";
            txtCircTtriceps.Size = new Size(150, 27);
            txtCircTtriceps.TabIndex = 10;
            txtCircTtriceps.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            // 
            // txtCircAbdominal
            // 
            txtCircAbdominal.DecimalPlaces = 2;
            txtCircAbdominal.Location = new Point(647, 65);
            txtCircAbdominal.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            txtCircAbdominal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtCircAbdominal.Name = "txtCircAbdominal";
            txtCircAbdominal.Size = new Size(150, 27);
            txtCircAbdominal.TabIndex = 9;
            txtCircAbdominal.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 67);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 8;
            label5.Text = "Circunferência abdominal";
            // 
            // txtAltura
            // 
            txtAltura.DecimalPlaces = 2;
            txtAltura.Location = new Point(287, 65);
            txtAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 27);
            txtAltura.TabIndex = 7;
            txtAltura.Value = new decimal(new int[] { 8, 0, 0, 65536 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 67);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.DecimalPlaces = 2;
            txtPeso.Location = new Point(64, 65);
            txtPeso.Maximum = new decimal(new int[] { 290, 0, 0, 0 });
            txtPeso.Minimum = new decimal(new int[] { 39, 0, 0, 0 });
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 27);
            txtPeso.TabIndex = 5;
            txtPeso.Value = new decimal(new int[] { 39, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Peso";
            // 
            // txtData
            // 
            txtData.Enabled = false;
            txtData.Location = new Point(117, 33);
            txtData.MaxLength = 100;
            txtData.Name = "txtData";
            txtData.Size = new Size(680, 27);
            txtData.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Data avaliação";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(64, 3);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(733, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnGerarAvaliacao);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 6;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.Location = new Point(151, 0);
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
            btnGerarAvaliacao.Size = new Size(151, 68);
            btnGerarAvaliacao.TabIndex = 1;
            btnGerarAvaliacao.Text = "Gerar avalição";
            btnGerarAvaliacao.UseVisualStyleBackColor = true;
            btnGerarAvaliacao.Click += btnGerarAvaliacao_Click;
            // 
            // frmAvaliacaoFisica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAvaliacaoFisica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avaliação física";
            Load += frmAvaliacaoFisica_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCircSupra).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCircTtriceps).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCircAbdominal).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPeso).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txtData;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Panel panel1;
        private Button btnSair;
        private Button btnGerarAvaliacao;
        private NumericUpDown txtPeso;
        private Label label3;
        private Label label6;
        private NumericUpDown txtCircTtriceps;
        private NumericUpDown txtCircAbdominal;
        private Label label5;
        private NumericUpDown txtAltura;
        private Label label4;
        private Label label8;
        private RichTextBox txtObjetivo;
        private Label label7;
        private NumericUpDown txtCircSupra;
    }
}