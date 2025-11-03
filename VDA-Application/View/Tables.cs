using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDA_Core.Controller;
using VDA_Core.Model;
using VDA_Core.Model.Entities;

namespace VDA_Application.View
{
    public partial class Tables : Form
    {
        Employee currentEmployee = AuthController.currentSession.currentEmployee;
        DatabaseContext _db = new DatabaseContext();

        public Tables()
        {
            InitializeComponent();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            EstilizarDataGridView();
            dataGridView1.DataSource = AuthController.tableValues.employees;

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle tabRect = tabControl1.GetTabRect(e.Index);
            Color pretoPrincipal = Color.FromArgb(15, 15, 20);
            Color cinzaEscuro = Color.FromArgb(30, 30, 40);


            // Customize background color
            if (e.State == DrawItemState.Selected)
            {
                g.FillRectangle(Brushes.MediumPurple, tabRect); // Selected tab color
            }
            else
            {
                g.FillRectangle(Brushes.LightGray, tabRect); // Unselected tab color
            }

            // Customize text
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(tabPage.Text, e.Font, Brushes.White, tabRect, sf);
            }

            // Draw border (optional)
            g.DrawRectangle(Pens.Black, tabRect);
        }

        private void EstilizarDataGridView()
        {
            Color azulPrincipal = Color.FromArgb(0, 74, 173);
            Color vermelhoPrincipal = Color.FromArgb(220, 20, 60);
            Color pretoPrincipal = Color.FromArgb(15, 15, 20);
            Color cinzaEscuro = Color.FromArgb(30, 30, 40);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = cinzaEscuro;
            dataGridView1.GridColor = Color.FromArgb(60, 60, 70);

            // 🎨 ESTILO DAS CÉLULAS
            dataGridView1.DefaultCellStyle.BackColor = cinzaEscuro;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.SelectionBackColor = azulPrincipal;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Padding = new Padding(8);

            // 🎨 ESTILO DAS CÉLULAS ALTERNADAS
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);

            // 🏆 ESTILO DO CABEÇALHO
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = pretoPrincipal;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = vermelhoPrincipal;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Tables_Load(object sender, EventArgs e)
        {



            userNameLabel.Text = currentEmployee.first_name + " " + currentEmployee.last_name;

            Button homeBtn = new Button();
            Button tablesBtn = new Button();
            Button graphsBtn = new Button();

            StyleSidebarButton(homeBtn, "Home");
            StyleSidebarButton(tablesBtn, "Tables");
            StyleSidebarButton(graphsBtn, "Graphs");

            homeBtn.Click += homeBtn_Click;
            //tablesBtn.Click += tablesBtn_Click;
            tablesBtn.MouseLeave += (s, e) => tablesBtn.BackColor = Color.FromArgb(90, 150, 90);
            graphsBtn.Click += graphsBtn_Click;

            StyleSpecialButton(tablesBtn, Color.FromArgb(90, 60, 170));

            buttonContainer.Controls.Add(homeBtn);
            buttonContainer.Controls.Add(tablesBtn);
            buttonContainer.Controls.Add(graphsBtn);


            logoutBtn.MouseEnter += (s, e) => logoutBtn.BackColor = Color.FromArgb(180, 60, 90); // ButtonHoverColor
            logoutBtn.MouseLeave += (s, e) => logoutBtn.BackColor = Color.Transparent;

        }
        private static void StyleSidebarButton(Button button, string text)
        {
            button.Text = text;
            button.ForeColor = Color.WhiteSmoke;
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button.Size = new Size(180, 40);
            button.Margin = new Padding(0, 5, 0, 5);
            button.TextAlign = ContentAlignment.MiddleLeft;

            // Hover effect
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(90, 60, 180); // ButtonHoverColor
            button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
        }
        private static void StyleSpecialButton(Button button, Color color)
        {
            button.BackColor = color;
            button.MouseEnter += (s, e) => button.BackColor = color; // ButtonHoverColor
            button.MouseLeave += (s, e) => button.BackColor = color;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            FormController.CreateForm(new Main(), false, true);
            this.Hide();
        }

        //private void tablesBtn_Click(object sender, EventArgs e)
        //{
        //    FormController.CreateForm(new Tables(), false, true);
        //    this.Hide();
        //}

        private void graphsBtn_Click(object sender, EventArgs e)
        {
            FormController.CreateForm(new Graphs(), false, true);
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AuthController.currentSession = new();
                FormController.CreateForm(new InitForm());
                this.Hide();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == null) return;
            switch (tabControl1.SelectedTab.Name)
            {
                case "EmployeesTab":
                    dataGridView1.DataSource = AuthController.tableValues.employees;
                    EmployeesTab.Controls.Clear();
                    EmployeesTab.Controls.Add(dataGridView1);
                    break;
                case "CustomersTab":
                    dataGridView1.DataSource = AuthController.tableValues.customers;
                    CustomersTab.Controls.Clear();
                    CustomersTab.Controls.Add(dataGridView1);
                    break;
                case "CategoriesTab":
                    dataGridView1.DataSource = AuthController.tableValues.customers;
                    CategoriesTab.Controls.Clear();
                    CategoriesTab.Controls.Add(dataGridView1);
                    break;
                case "ProductsTab":
                    dataGridView1.DataSource = AuthController.tableValues.customers;
                    ProductsTab.Controls.Clear();
                    ProductsTab.Controls.Add(dataGridView1);
                    break;
                case "PurchasesTab":
                    dataGridView1.DataSource = AuthController.tableValues.customers;
                    PurchasesTab.Controls.Clear();
                    PurchasesTab.Controls.Add(dataGridView1);
                    break;
                case "PurchaseItensTab":
                    dataGridView1.DataSource = AuthController.tableValues.customers;
                    PurchaseItensTab.Controls.Clear();
                    PurchaseItensTab.Controls.Add(dataGridView1);
                    break;
                case "UsersTab":
                    dataGridView1.DataSource = AuthController.tableValues.customers;
                    UsersTab.Controls.Clear();
                    UsersTab.Controls.Add(dataGridView1);
                    break;
                default:
                    break;
            }
        }
    }
}
