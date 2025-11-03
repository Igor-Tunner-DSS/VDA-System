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
            CustomersTab = new TabPage();
            ProductsTab = new TabPage();
            PurchasesTab = new TabPage();
            CategoriesTab = new TabPage();
            PurchaseItensTab = new TabPage();
            UsersTab = new TabPage();
            dataGridView1 = new DataGridView();
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
            titleLabel.Size = new Size(119, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Table Viewer";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(20, 20, 30);
            contentPanel.Controls.Add(tabControl1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(180, 60);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(10);
            contentPanel.Size = new Size(858, 555);
            contentPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EmployeesTab);
            tabControl1.Controls.Add(CustomersTab);
            tabControl1.Controls.Add(ProductsTab);
            tabControl1.Controls.Add(PurchasesTab);
            tabControl1.Controls.Add(CategoriesTab);
            tabControl1.Controls.Add(PurchaseItensTab);
            tabControl1.Controls.Add(UsersTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(10, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(838, 535);
            tabControl1.TabIndex = 0;
            // 
            // EmployeesTab
            // 
            EmployeesTab.Controls.Add(dataGridView1);
            EmployeesTab.Location = new Point(4, 24);
            EmployeesTab.Name = "EmployeesTab";
            EmployeesTab.Padding = new Padding(3);
            EmployeesTab.Size = new Size(830, 507);
            EmployeesTab.TabIndex = 0;
            EmployeesTab.Text = "Employees";
            EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Location = new Point(4, 24);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(830, 507);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Customers";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // ProductsTab
            // 
            ProductsTab.Location = new Point(4, 24);
            ProductsTab.Name = "ProductsTab";
            ProductsTab.Padding = new Padding(3);
            ProductsTab.Size = new Size(830, 507);
            ProductsTab.TabIndex = 2;
            ProductsTab.Text = "Products";
            ProductsTab.UseVisualStyleBackColor = true;
            // 
            // PurchasesTab
            // 
            PurchasesTab.Location = new Point(4, 24);
            PurchasesTab.Name = "PurchasesTab";
            PurchasesTab.Padding = new Padding(3);
            PurchasesTab.Size = new Size(830, 507);
            PurchasesTab.TabIndex = 3;
            PurchasesTab.Text = "Purchases";
            PurchasesTab.UseVisualStyleBackColor = true;
            // 
            // CategoriesTab
            // 
            CategoriesTab.Location = new Point(4, 24);
            CategoriesTab.Name = "CategoriesTab";
            CategoriesTab.Padding = new Padding(3);
            CategoriesTab.Size = new Size(830, 507);
            CategoriesTab.TabIndex = 4;
            CategoriesTab.Text = "Categories";
            CategoriesTab.UseVisualStyleBackColor = true;
            // 
            // PurchaseItensTab
            // 
            PurchaseItensTab.Location = new Point(4, 24);
            PurchaseItensTab.Name = "PurchaseItensTab";
            PurchaseItensTab.Padding = new Padding(3);
            PurchaseItensTab.Size = new Size(830, 507);
            PurchaseItensTab.TabIndex = 5;
            PurchaseItensTab.Text = "Purchase Itens";
            PurchaseItensTab.UseVisualStyleBackColor = true;
            // 
            // UsersTab
            // 
            UsersTab.Location = new Point(4, 24);
            UsersTab.Name = "UsersTab";
            UsersTab.Padding = new Padding(3);
            UsersTab.Size = new Size(830, 507);
            UsersTab.TabIndex = 6;
            UsersTab.Text = "Users";
            UsersTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(824, 501);
            dataGridView1.TabIndex = 0;
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(1038, 615);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Tables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tables - VDA Application";
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