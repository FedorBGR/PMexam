namespace PMexam
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            lblLogin = new Label();
            lblPasword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(275, 142);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(271, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(275, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(271, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblLogin.Location = new Point(275, 118);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 21);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Логин";
            // 
            // lblPasword
            // 
            lblPasword.AutoSize = true;
            lblPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPasword.Location = new Point(275, 178);
            lblPasword.Name = "lblPasword";
            lblPasword.Size = new Size(70, 21);
            lblPasword.TabIndex = 3;
            lblPasword.Text = "Пароль";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Location = new Point(296, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(226, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.BackColor = SystemColors.Control;
            btnRegister.FlatStyle = FlatStyle.System;
            btnRegister.Location = new Point(363, 283);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(90, 32);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPasword);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lblLogin;
        private Label lblPasword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
