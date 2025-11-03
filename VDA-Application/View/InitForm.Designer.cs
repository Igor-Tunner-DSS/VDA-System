namespace VDA_Application
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            loginBox = new TextBox();
            passwordBox = new TextBox();
            panel1 = new Panel();
            loginButton = new Button();
            idLabel = new Label();
            idBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginBox.Location = new Point(0, 113);
            loginBox.Margin = new Padding(4, 3, 4, 3);
            loginBox.Name = "loginBox";
            loginBox.PlaceholderText = "name@example.com";
            loginBox.Size = new Size(499, 31);
            loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(0, 211);
            passwordBox.Margin = new Padding(4, 3, 4, 3);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Your password";
            passwordBox.Size = new Size(499, 31);
            passwordBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(emailLabel);
            panel1.Location = new Point(931, 110);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(26, 25, 26, 25);
            panel1.Size = new Size(533, 480);
            panel1.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(386, 433);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(117, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(0, 280);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(113, 25);
            idLabel.TabIndex = 4;
            idLabel.Text = "Employee ID";
            // 
            // idBox
            // 
            idBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idBox.Location = new Point(0, 311);
            idBox.Margin = new Padding(4, 3, 4, 3);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Your company provided identification number";
            idBox.Size = new Size(499, 31);
            idBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(0, 180);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(0, 81);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(56, 25);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Login";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(886, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 797);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(886, 797);
            panel3.TabIndex = 5;
            // 
            // InitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 797);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "InitForm";
            Text = "Login screen";
            FormClosed += InitForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox loginBox;
        private TextBox passwordBox;
        private Panel panel1;
        private Label idLabel;
        private TextBox idBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Button loginButton;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
    }
}
