namespace Chronos.Avaliacao.Avaliacao.Principal
{
    partial class Principal
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
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelPrincipal.Controls.OfType<Forms>().FirstOrDefault();
            formulario = new Forms();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Dock = DockStyle.None;
            panelPrincipal.Controls.Add(formulario);
            panelPrincipal.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSair = new Button();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            exerciciosToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            avaliaçãoToolStripMenuItem = new ToolStripMenuItem();
            agendamentosToolStripMenuItem = new ToolStripMenuItem();
            anamneseToolStripMenuItem = new ToolStripMenuItem();
            avaliaçãoToolStripMenuItem1 = new ToolStripMenuItem();
            pósAvaliaçãoToolStripMenuItem = new ToolStripMenuItem();
            treinoToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            agendamentosDoDiaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Controls.Add(menuStrip1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 450);
            panelPrincipal.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.avaliacao;
            pictureBox1.Location = new Point(0, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSair);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 72);
            panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Left;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 72);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.ForestGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, avaliaçãoToolStripMenuItem, configuraçõesToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, exerciciosToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.ForeColor = Color.White;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.ForestGreen;
            clientesToolStripMenuItem.ForeColor = Color.White;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(224, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // exerciciosToolStripMenuItem
            // 
            exerciciosToolStripMenuItem.BackColor = Color.ForestGreen;
            exerciciosToolStripMenuItem.ForeColor = Color.White;
            exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            exerciciosToolStripMenuItem.Size = new Size(224, 26);
            exerciciosToolStripMenuItem.Text = "Exercicios";
            exerciciosToolStripMenuItem.Click += exerciciosToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.BackColor = Color.ForestGreen;
            usuáriosToolStripMenuItem.ForeColor = Color.White;
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(224, 26);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // avaliaçãoToolStripMenuItem
            // 
            avaliaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agendamentosToolStripMenuItem, anamneseToolStripMenuItem, pósAvaliaçãoToolStripMenuItem });
            avaliaçãoToolStripMenuItem.ForeColor = Color.White;
            avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            avaliaçãoToolStripMenuItem.Size = new Size(88, 24);
            avaliaçãoToolStripMenuItem.Text = "Avaliação";
            // 
            // agendamentosToolStripMenuItem
            // 
            agendamentosToolStripMenuItem.BackColor = Color.ForestGreen;
            agendamentosToolStripMenuItem.ForeColor = Color.White;
            agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            agendamentosToolStripMenuItem.Size = new Size(193, 26);
            agendamentosToolStripMenuItem.Text = "Agendamentos";
            agendamentosToolStripMenuItem.Click += agendamentosToolStripMenuItem_Click;
            // 
            // anamneseToolStripMenuItem
            // 
            anamneseToolStripMenuItem.BackColor = Color.ForestGreen;
            anamneseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avaliaçãoToolStripMenuItem1 });
            anamneseToolStripMenuItem.ForeColor = Color.White;
            anamneseToolStripMenuItem.Name = "anamneseToolStripMenuItem";
            anamneseToolStripMenuItem.Size = new Size(193, 26);
            anamneseToolStripMenuItem.Text = "Anamnese";
            // 
            // avaliaçãoToolStripMenuItem1
            // 
            avaliaçãoToolStripMenuItem1.BackColor = Color.ForestGreen;
            avaliaçãoToolStripMenuItem1.ForeColor = Color.White;
            avaliaçãoToolStripMenuItem1.Name = "avaliaçãoToolStripMenuItem1";
            avaliaçãoToolStripMenuItem1.Size = new Size(157, 26);
            avaliaçãoToolStripMenuItem1.Text = "Avaliação";
            avaliaçãoToolStripMenuItem1.Click += avaliaçãoToolStripMenuItem1_Click;
            // 
            // pósAvaliaçãoToolStripMenuItem
            // 
            pósAvaliaçãoToolStripMenuItem.BackColor = Color.ForestGreen;
            pósAvaliaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { treinoToolStripMenuItem });
            pósAvaliaçãoToolStripMenuItem.ForeColor = Color.White;
            pósAvaliaçãoToolStripMenuItem.Name = "pósAvaliaçãoToolStripMenuItem";
            pósAvaliaçãoToolStripMenuItem.Size = new Size(193, 26);
            pósAvaliaçãoToolStripMenuItem.Text = "Pós - Avaliação";
            // 
            // treinoToolStripMenuItem
            // 
            treinoToolStripMenuItem.BackColor = Color.ForestGreen;
            treinoToolStripMenuItem.ForeColor = Color.White;
            treinoToolStripMenuItem.Name = "treinoToolStripMenuItem";
            treinoToolStripMenuItem.Size = new Size(193, 26);
            treinoToolStripMenuItem.Text = "Plano de treino";
            treinoToolStripMenuItem.Click += treinoToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem1, agendamentosDoDiaToolStripMenuItem });
            configuraçõesToolStripMenuItem.ForeColor = Color.White;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(90, 24);
            configuraçõesToolStripMenuItem.Text = "Relatórios";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.BackColor = Color.ForestGreen;
            clientesToolStripMenuItem1.ForeColor = Color.White;
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(240, 26);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // agendamentosDoDiaToolStripMenuItem
            // 
            agendamentosDoDiaToolStripMenuItem.BackColor = Color.ForestGreen;
            agendamentosDoDiaToolStripMenuItem.ForeColor = Color.White;
            agendamentosDoDiaToolStripMenuItem.Name = "agendamentosDoDiaToolStripMenuItem";
            agendamentosDoDiaToolStripMenuItem.Size = new Size(240, 26);
            agendamentosDoDiaToolStripMenuItem.Text = "Agendamentos do dia";
            agendamentosDoDiaToolStripMenuItem.Click += agendamentosDoDiaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.ForeColor = Color.White;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            sairToolStripMenuItem.DoubleClick += sairToolStripMenuItem_DoubleClick;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            FormClosing += Principal_FormClosing;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPrincipal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem exerciciosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem agendamentosToolStripMenuItem;
        private ToolStripMenuItem anamneseToolStripMenuItem;
        private ToolStripMenuItem pósAvaliaçãoToolStripMenuItem;
        private ToolStripMenuItem avaliaçãoToolStripMenuItem1;
        private ToolStripMenuItem treinoToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem agendamentosDoDiaToolStripMenuItem;
        private Panel panel1;
        private Button btnSair;
        private PictureBox pictureBox1;
    }
}