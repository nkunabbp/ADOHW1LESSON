namespace ADOHW1LESSON
{
    partial class RegForm
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
            Namelabel = new Label();
            Surnamelabel = new Label();
            AgeLabel = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            SurNametextBox = new TextBox();
            NametextBox = new TextBox();
            AgetextBox = new TextBox();
            PasswordtextBox = new TextBox();
            LogintextBox = new TextBox();
            Regbutton = new Button();
            SuspendLayout();
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(34, 64);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(59, 25);
            Namelabel.TabIndex = 1;
            Namelabel.Text = "Name";
            // 
            // Surnamelabel
            // 
            Surnamelabel.AutoSize = true;
            Surnamelabel.Location = new Point(34, 120);
            Surnamelabel.Name = "Surnamelabel";
            Surnamelabel.Size = new Size(82, 25);
            Surnamelabel.TabIndex = 2;
            Surnamelabel.Text = "Surname";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(34, 178);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 25);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(34, 237);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(56, 25);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(34, 294);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // SurNametextBox
            // 
            SurNametextBox.Location = new Point(152, 120);
            SurNametextBox.Name = "SurNametextBox";
            SurNametextBox.Size = new Size(327, 31);
            SurNametextBox.TabIndex = 6;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(152, 64);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(327, 31);
            NametextBox.TabIndex = 7;
            // 
            // AgetextBox
            // 
            AgetextBox.Location = new Point(152, 178);
            AgetextBox.Name = "AgetextBox";
            AgetextBox.Size = new Size(327, 31);
            AgetextBox.TabIndex = 9;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(152, 294);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(327, 31);
            PasswordtextBox.TabIndex = 10;
            // 
            // LogintextBox
            // 
            LogintextBox.Location = new Point(152, 237);
            LogintextBox.Name = "LogintextBox";
            LogintextBox.Size = new Size(327, 31);
            LogintextBox.TabIndex = 11;
            // 
            // Regbutton
            // 
            Regbutton.BackColor = Color.SkyBlue;
            Regbutton.Location = new Point(196, 357);
            Regbutton.Name = "Regbutton";
            Regbutton.Size = new Size(112, 34);
            Regbutton.TabIndex = 12;
            Regbutton.Text = "Register";
            Regbutton.UseVisualStyleBackColor = false;
            Regbutton.Click += Regbutton_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 610);
            Controls.Add(Regbutton);
            Controls.Add(LogintextBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(AgetextBox);
            Controls.Add(NametextBox);
            Controls.Add(SurNametextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(AgeLabel);
            Controls.Add(Surnamelabel);
            Controls.Add(Namelabel);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Namelabel;
        private Label Surnamelabel;
        private Label AgeLabel;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox SurNametextBox;
        private TextBox NametextBox;
        private TextBox AgetextBox;
        private TextBox PasswordtextBox;
        private TextBox LogintextBox;
        private Button Regbutton;
    }
}