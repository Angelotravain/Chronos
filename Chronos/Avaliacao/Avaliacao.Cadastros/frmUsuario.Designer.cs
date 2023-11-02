namespace Chronos.Avaliacao.Avaliacao.Cadastros
{
    partial class frmUsuario
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
            gridUsuario = new DataGridView();
            panel2 = new Panel();
            cbmNivelAcesso = new ComboBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnSair = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUsuario).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridUsuario
            // 
            gridUsuario.BackgroundColor = Color.White;
            gridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuario.Dock = DockStyle.Fill;
            gridUsuario.Location = new Point(0, 159);
            gridUsuario.Name = "gridUsuario";
            gridUsuario.RowHeadersWidth = 51;
            gridUsuario.RowTemplate.Height = 29;
            gridUsuario.Size = new Size(800, 291);
            gridUsuario.TabIndex = 5;
            gridUsuario.CellContentClick += gridUsuario_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbmNivelAcesso);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 91);
            panel2.TabIndex = 4;
            // 
            // cbmNivelAcesso
            // 
            cbmNivelAcesso.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbmNivelAcesso.FormattingEnabled = true;
            cbmNivelAcesso.Items.AddRange(new object[] { "Gerente (geral)", "Avaliador" });
            cbmNivelAcesso.Location = new Point(130, 46);
            cbmNivelAcesso.Name = "cbmNivelAcesso";
            cbmNivelAcesso.Size = new Size(658, 28);
            cbmNivelAcesso.TabIndex = 16;
            cbmNivelAcesso.SelectedIndexChanged += cbmNivelAcesso_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 15;
            label3.Text = "Nível de acesso";
            label3.UseWaitCursor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(316, 6);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(472, 27);
            txtSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 6);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(62, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(193, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
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
            panel1.TabIndex = 3;
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
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridUsuario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUsuario";
            Text = "Usuários";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridUsuario;
        private Panel panel2;
        private TextBox txtSenha;
        private Label label2;
        private TextBox txtUsuario;
        private Label label1;
        private Panel panel1;
        private Button btnSair;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private ComboBox cbmNivelAcesso;
        private Label label3;
    }
}