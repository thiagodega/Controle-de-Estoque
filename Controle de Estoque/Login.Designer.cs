namespace Controle_de_Estoque
{
    partial class Login
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
            Usuario = new TextBox();
            Senha = new TextBox();
            User_lbl = new Label();
            Password_lbl = new Label();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Usuario.Location = new Point(172, 100);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(166, 23);
            Usuario.TabIndex = 0;
            // 
            // Senha
            // 
            Senha.Location = new Point(169, 158);
            Senha.Name = "Senha";
            Senha.PasswordChar = '*';
            Senha.Size = new Size(169, 23);
            Senha.TabIndex = 1;
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            User_lbl.Location = new Point(233, 82);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(49, 15);
            User_lbl.TabIndex = 2;
            User_lbl.Text = "Usuário";
            // 
            // Password_lbl
            // 
            Password_lbl.AutoSize = true;
            Password_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Password_lbl.Location = new Point(233, 140);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(41, 15);
            Password_lbl.TabIndex = 3;
            Password_lbl.Text = "Senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 313);
            Controls.Add(Password_lbl);
            Controls.Add(User_lbl);
            Controls.Add(Senha);
            Controls.Add(Usuario);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usuario;
        private TextBox Senha;
        private Label User_lbl;
        private Label Password_lbl;
    }
}