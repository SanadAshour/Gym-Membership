namespace ClubUI
{
    partial class frmLogin
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
            LoginBtn = new Button();
            emailTB = new TextBox();
            PasswordTB = new TextBox();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(131, 179);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(138, 64);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "LOG IN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(82, 76);
            emailTB.Name = "emailTB";
            emailTB.PlaceholderText = "E-MAIL";
            emailTB.Size = new Size(236, 27);
            emailTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(82, 121);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.PlaceholderText = "PASSWORD";
            PasswordTB.Size = new Size(236, 27);
            PasswordTB.TabIndex = 2;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 352);
            Controls.Add(PasswordTB);
            Controls.Add(emailTB);
            Controls.Add(LoginBtn);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private TextBox emailTB;
        private TextBox PasswordTB;
    }
}