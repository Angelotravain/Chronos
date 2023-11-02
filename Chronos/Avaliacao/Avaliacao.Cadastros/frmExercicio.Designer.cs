namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    partial class frmExercicio
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
            gridExercicio = new DataGridView();
            panel2 = new Panel();
            pcImagemExercicio = new PictureBox();
            cbmIntensidade = new ComboBox();
            cbmGrupoMuscular = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtExercicio = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnSair = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridExercicio).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcImagemExercicio).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridExercicio
            // 
            gridExercicio.BackgroundColor = Color.White;
            gridExercicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridExercicio.Dock = DockStyle.Fill;
            gridExercicio.Location = new Point(0, 247);
            gridExercicio.Name = "gridExercicio";
            gridExercicio.RowHeadersWidth = 51;
            gridExercicio.RowTemplate.Height = 29;
            gridExercicio.Size = new Size(800, 203);
            gridExercicio.TabIndex = 8;
            gridExercicio.CellDoubleClick += gridExercicio_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(pcImagemExercicio);
            panel2.Controls.Add(cbmIntensidade);
            panel2.Controls.Add(cbmGrupoMuscular);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtExercicio);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 179);
            panel2.TabIndex = 7;
            // 
            // pcImagemExercicio
            // 
            pcImagemExercicio.Image = Properties.Resources.sem_imagem;
            pcImagemExercicio.Location = new Point(416, 6);
            pcImagemExercicio.Name = "pcImagemExercicio";
            pcImagemExercicio.Size = new Size(286, 167);
            pcImagemExercicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pcImagemExercicio.TabIndex = 18;
            pcImagemExercicio.TabStop = false;
            pcImagemExercicio.Click += pcImagemExercicio_Click;
            // 
            // cbmIntensidade
            // 
            cbmIntensidade.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbmIntensidade.FormattingEnabled = true;
            cbmIntensidade.Items.AddRange(new object[] { "Baixa intensidade", "Média intensidade", "Alta intensidade" });
            cbmIntensidade.Location = new Point(94, 40);
            cbmIntensidade.Name = "cbmIntensidade";
            cbmIntensidade.Size = new Size(316, 28);
            cbmIntensidade.TabIndex = 17;
            // 
            // cbmGrupoMuscular
            // 
            cbmGrupoMuscular.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbmGrupoMuscular.FormattingEnabled = true;
            cbmGrupoMuscular.Items.AddRange(new object[] { "Peitoral (Peito)", "Dorsal (Costas)", "Ombros (Deltoides)", "Braços (Bíceps)", "Braços (Tríceps)", "Pernas - (Quadríceps) ", "Pernas - (Isquiotibiais)", "Glúteos", "Abdômen (Core)", "Panturrilhas", "Músculos Estabilizadores" });
            cbmGrupoMuscular.Location = new Point(130, 74);
            cbmGrupoMuscular.Name = "cbmGrupoMuscular";
            cbmGrupoMuscular.Size = new Size(280, 28);
            cbmGrupoMuscular.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 15;
            label3.Text = "Grupo muscular";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 44);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Intensidade";
            // 
            // txtExercicio
            // 
            txtExercicio.Location = new Point(74, 7);
            txtExercicio.Name = "txtExercicio";
            txtExercicio.Size = new Size(336, 27);
            txtExercicio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Exercício";
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
            // frmExercicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridExercicio);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmExercicio";
            Text = "Exercícios";
            Load += frmExercicio_Load;
            ((System.ComponentModel.ISupportInitialize)gridExercicio).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcImagemExercicio).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridExercicio;
        private Panel panel2;
        private ComboBox cbmGrupoMuscular;
        private Label label3;
        private Label label2;
        private TextBox txtExercicio;
        private Label label1;
        private Panel panel1;
        private Button btnSair;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private ComboBox cbmIntensidade;
        private PictureBox pcImagemExercicio;
    }
}