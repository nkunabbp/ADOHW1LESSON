namespace ADOHW1LESSON
{
    partial class RegisterWin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            SingUpButton = new Button();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(470, 119);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(61, 25);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Login ";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(400, 147);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(206, 31);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(455, 209);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(400, 237);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(206, 31);
            PasswordTextBox.TabIndex = 3;
            // 
            // SingUpButton
            // 
            SingUpButton.BackColor = Color.SkyBlue;
            SingUpButton.Location = new Point(357, 311);
            SingUpButton.Name = "SingUpButton";
            SingUpButton.Size = new Size(112, 34);
            SingUpButton.TabIndex = 4;
            SingUpButton.Text = "Sign Up";
            SingUpButton.UseVisualStyleBackColor = false;
            SingUpButton.Click += SingUpButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.SkyBlue;
            SignInButton.Location = new Point(552, 311);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(112, 34);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // RegisterWin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 486);
            Controls.Add(SignInButton);
            Controls.Add(SingUpButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginLabel);
            Name = "RegisterWin";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox LoginTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button SingUpButton;
        private Button SignInButton;
    }
}
