using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace VDA_Application.View
{
    partial class Graphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // --- UI Components ---
        private Panel sidebarPanel;
        private Panel headerPanel;
        private Panel contentPanel;
        private Label titleLabel;
        private Button btnHome;
        private Button btnResult;
        private Button btnChat;
        private Button btnMessages;
        private Button btnNotification;
        private Button btnSetting;
        private FlowLayoutPanel buttonContainer;
        private Panel userPanel;
        private Label userNameLabel;
        private PictureBox pictureBox1;
        private Button logoutBtn;
        private Panel logoutPanel;

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
            sidebarPanel = new Panel();
            buttonContainer = new FlowLayoutPanel();
            logoutPanel = new Panel();
            logoutBtn = new Button();
            userPanel = new Panel();
            userNameLabel = new Label();
            pictureBox1 = new PictureBox();
            headerPanel = new Panel();
            titleLabel = new Label();
            contentPanel = new Panel();
            sidebarPanel.SuspendLayout();
            logoutPanel.SuspendLayout();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(25, 25, 35);
            sidebarPanel.Controls.Add(buttonContainer);
            sidebarPanel.Controls.Add(logoutPanel);
            sidebarPanel.Controls.Add(userPanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(180, 615);
            sidebarPanel.TabIndex = 2;
            // 
            // buttonContainer
            // 
            buttonContainer.Dock = DockStyle.Fill;
            buttonContainer.FlowDirection = FlowDirection.TopDown;
            buttonContainer.Location = new Point(0, 169);
            buttonContainer.Margin = new Padding(0);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Padding = new Padding(0, 20, 0, 0);
            buttonContainer.Size = new Size(180, 406);
            buttonContainer.TabIndex = 0;
            buttonContainer.WrapContents = false;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logoutBtn);
            logoutPanel.Dock = DockStyle.Bottom;
            logoutPanel.Location = new Point(0, 575);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(180, 40);
            logoutPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.Dock = DockStyle.Fill;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI", 10F);
            logoutBtn.ForeColor = Color.WhiteSmoke;
            logoutBtn.Location = new Point(0, 0);
            logoutBtn.Margin = new Padding(10, 5, 10, 5);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(180, 40);
            logoutBtn.TabIndex = 1;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(userNameLabel);
            userPanel.Controls.Add(pictureBox1);
            userPanel.Dock = DockStyle.Top;
            userPanel.Location = new Point(0, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(180, 169);
            userPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoEllipsis = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("UD Digi Kyokasho NK", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            userNameLabel.ForeColor = Color.WhiteSmoke;
            userNameLabel.Location = new Point(3, 136);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(171, 25);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Dashboard User";
            userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon1;
            pictureBox1.Location = new Point(25, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(40, 40, 60);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(180, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(858, 60);
            headerPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.WhiteSmoke;
            titleLabel.Location = new Point(17, 18);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(186, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Graphs and Statistics";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(20, 20, 30);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(180, 60);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(10);
            contentPanel.Size = new Size(858, 555);
            contentPanel.TabIndex = 0;
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(1038, 615);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Graphs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphs - VDA Application";
            Load += Graphs_Load;
            sidebarPanel.ResumeLayout(false);
            logoutPanel.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}