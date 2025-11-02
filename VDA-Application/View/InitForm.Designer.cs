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
            emailBox = new TextBox();
            passwordBox = new TextBox();
            panel1 = new Panel();
            loginButton = new Button();
            idLabel = new Label();
            idBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // emailBox
            // 
            emailBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailBox.Location = new Point(0, 92);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "name@example.com";
            emailBox.Size = new Size(403, 27);
            emailBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(0, 170);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Your password";
            passwordBox.Size = new Size(403, 27);
            passwordBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(emailLabel);
            panel1.Location = new Point(745, 88);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(426, 384);
            panel1.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(309, 350);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(0, 225);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(94, 20);
            idLabel.TabIndex = 4;
            idLabel.Text = "Employee ID";
            // 
            // idBox
            // 
            idBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idBox.Location = new Point(0, 250);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Your company provided identification number";
            idBox.Size = new Size(403, 27);
            idBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(0, 145);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(0, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Login";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 637);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(709, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 637);
            panel2.TabIndex = 4;
            // 
            // InitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 637);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "InitForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox emailBox;
        private TextBox passwordBox;
        private Panel panel1;
        private Label idLabel;
        private TextBox idBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Button loginButton;
        private DataGridView dataGridView1;
        private Panel panel2;
    }
}
