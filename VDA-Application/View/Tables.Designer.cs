using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace VDA_Application.View
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
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
            tabControl1 = new TabControl();
            EmployeesTab = new TabPage();
            dataGridView1 = new DataGridView();
            CustomersTab = new TabPage();
            ProductsTab = new TabPage();
            PurchasesTab = new TabPage();
            CategoriesTab = new TabPage();
            PurchaseItensTab = new TabPage();
            UsersTab = new TabPage();
            sidebarPanel.SuspendLayout();
            logoutPanel.SuspendLayout();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            sidebarPanel.Margin = new Padding(4, 5, 4, 5);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(257, 1025);
            sidebarPanel.TabIndex = 2;
            // 
            // buttonContainer
            // 
            buttonContainer.Dock = DockStyle.Fill;
            buttonContainer.FlowDirection = FlowDirection.TopDown;
            buttonContainer.Location = new Point(0, 282);
            buttonContainer.Margin = new Padding(0);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Padding = new Padding(0, 33, 0, 0);
            buttonContainer.Size = new Size(257, 676);
            buttonContainer.TabIndex = 0;
            buttonContainer.WrapContents = false;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logoutBtn);
            logoutPanel.Dock = DockStyle.Bottom;
            logoutPanel.Location = new Point(0, 958);
            logoutPanel.Margin = new Padding(4, 5, 4, 5);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(257, 67);
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
            logoutBtn.Margin = new Padding(14, 8, 14, 8);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(257, 67);
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
            userPanel.Margin = new Padding(4, 5, 4, 5);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(257, 282);
            userPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoEllipsis = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            userNameLabel.ForeColor = Color.WhiteSmoke;
            userNameLabel.Location = new Point(4, 227);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(244, 42);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Dashboard User";
            userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon1;
            pictureBox1.Location = new Point(36, 43);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(40, 40, 60);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(257, 0);
            headerPanel.Margin = new Padding(4, 5, 4, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1226, 100);
            headerPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.WhiteSmoke;
            titleLabel.Location = new Point(24, 30);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(177, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Table Viewer";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(20, 20, 30);
            contentPanel.Controls.Add(tabControl1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(257, 100);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(14, 17, 14, 17);
            contentPanel.Size = new Size(1226, 925);
            contentPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(EmployeesTab);
            tabControl1.Controls.Add(CustomersTab);
            tabControl1.Controls.Add(ProductsTab);
            tabControl1.Controls.Add(PurchasesTab);
            tabControl1.Controls.Add(CategoriesTab);
            tabControl1.Controls.Add(PurchaseItensTab);
            tabControl1.Controls.Add(UsersTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(14, 17);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1198, 891);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // EmployeesTab
            // 
            EmployeesTab.BackColor = Color.FromArgb(30, 30, 40);
            EmployeesTab.Controls.Add(dataGridView1);
            EmployeesTab.ForeColor = SystemColors.ActiveCaption;
            EmployeesTab.Location = new Point(4, 37);
            EmployeesTab.Margin = new Padding(4, 5, 4, 5);
            EmployeesTab.Name = "EmployeesTab";
            EmployeesTab.Size = new Size(1190, 850);
            EmployeesTab.TabIndex = 0;
            EmployeesTab.Text = "Employees";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1190, 850);
            dataGridView1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Location = new Point(4, 37);
            CustomersTab.Margin = new Padding(4, 5, 4, 5);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1190, 850);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Customers";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // ProductsTab
            // 
            ProductsTab.Location = new Point(4, 37);
            ProductsTab.Margin = new Padding(4, 5, 4, 5);
            ProductsTab.Name = "ProductsTab";
            ProductsTab.Size = new Size(1190, 850);
            ProductsTab.TabIndex = 2;
            ProductsTab.Text = "Products";
            ProductsTab.UseVisualStyleBackColor = true;
            // 
            // PurchasesTab
            // 
            PurchasesTab.Location = new Point(4, 37);
            PurchasesTab.Margin = new Padding(4, 5, 4, 5);
            PurchasesTab.Name = "PurchasesTab";
            PurchasesTab.Size = new Size(1190, 850);
            PurchasesTab.TabIndex = 3;
            PurchasesTab.Text = "Purchases";
            PurchasesTab.UseVisualStyleBackColor = true;
            // 
            // CategoriesTab
            // 
            CategoriesTab.Location = new Point(4, 37);
            CategoriesTab.Margin = new Padding(4, 5, 4, 5);
            CategoriesTab.Name = "CategoriesTab";
            CategoriesTab.Size = new Size(1190, 850);
            CategoriesTab.TabIndex = 4;
            CategoriesTab.Text = "Categories";
            CategoriesTab.UseVisualStyleBackColor = true;
            // 
            // PurchaseItensTab
            // 
            PurchaseItensTab.Location = new Point(4, 37);
            PurchaseItensTab.Margin = new Padding(4, 5, 4, 5);
            PurchaseItensTab.Name = "PurchaseItensTab";
            PurchaseItensTab.Size = new Size(1190, 850);
            PurchaseItensTab.TabIndex = 5;
            PurchaseItensTab.Text = "Purchase Itens";
            PurchaseItensTab.UseVisualStyleBackColor = true;
            // 
            // UsersTab
            // 
            UsersTab.Location = new Point(4, 37);
            UsersTab.Margin = new Padding(4, 5, 4, 5);
            UsersTab.Name = "UsersTab";
            UsersTab.Size = new Size(1190, 850);
            UsersTab.TabIndex = 6;
            UsersTab.Text = "Users";
            UsersTab.UseVisualStyleBackColor = true;
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(1483, 1025);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Tables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tables - VDA Application";
            FormClosed += Tables_FormClosed;
            Load += Tables_Load;
            sidebarPanel.ResumeLayout(false);
            logoutPanel.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            EmployeesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage EmployeesTab;
        private TabPage CustomersTab;
        private TabPage ProductsTab;
        private TabPage PurchasesTab;
        private TabPage CategoriesTab;
        private TabPage PurchaseItensTab;
        private DataGridView dataGridView1;
        private TabPage UsersTab;
    }
}