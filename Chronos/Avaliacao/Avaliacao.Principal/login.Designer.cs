namespace Chronos.Avaliacao.Avaliacao.Principal
{
    partial class login
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
            label1 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(64, 9);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(324, 27);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(64, 42);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(324, 27);
            txtSenha.TabIndex = 3;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(233, 75);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 174);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso ao sistema";
            FormClosing += login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label2;
        private Button button1;
    }
}