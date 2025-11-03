using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDA_Application.View;
using VDA_Core.Controller;
using VDA_Core.Model.Entities;
using System.Windows.Forms.DataVisualization.Charting;


namespace VDA_Application
{
    public partial class Main : Form
    {
        Employee currentEmployee = AuthController.currentSession.currentEmployee;
        // Dashboard panels
        private System.Windows.Forms.TableLayoutPanel dashboardLayout;
        private System.Windows.Forms.Panel dataCard1;
        private System.Windows.Forms.Panel dataCard2;
        private System.Windows.Forms.Panel dataCard3;
        private System.Windows.Forms.Panel dataCard4;
        private System.Windows.Forms.Panel dataCard5;
        private System.Windows.Forms.Panel dataCard6;
        private Chart chart1;

        public Main()
        {
            this.dashboardLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataCard1 = new System.Windows.Forms.Panel();
            this.dataCard2 = new System.Windows.Forms.Panel();
            this.dataCard3 = new System.Windows.Forms.Panel();
            this.dataCard4 = new System.Windows.Forms.Panel();
            this.dataCard5 = new System.Windows.Forms.Panel();
            this.dataCard6 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            InitializeComponent();


            // Dashboard Layout
            this.dashboardLayout.ColumnCount = 3;
            this.dashboardLayout.RowCount = 2;
            this.dashboardLayout.Dock = DockStyle.Fill;
            this.dashboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.dashboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.dashboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            // Card Style Helper
            void StyleCard(Panel card, string title, string value)
            {
                card.BackColor = System.Drawing.Color.FromArgb(70, 40, 150);
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Dock = DockStyle.Fill;
                card.Margin = new Padding(10);

                Label lblTitle = new Label()
                {
                    Text = title,
                    ForeColor = System.Drawing.Color.LightGray,
                    Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Regular),
                    Dock = DockStyle.Top,
                    Height = 40,
                    TextAlign = ContentAlignment.TopLeft,
                    Padding = new Padding(10, 10, 0, 0)
                };

                Label lblValue = new Label()
                {
                    Text = value,
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Segoe UI", 20F, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                card.Controls.Add(lblValue);
                card.Controls.Add(lblTitle);
            }

            // Create cards
            StyleCard(this.dataCard2, "Daily", "19");
            StyleCard(this.dataCard1, "Monthly", "285");
            StyleCard(this.dataCard3, "Yearly", "3520");
            StyleCard(this.dataCard4, "A", "68209");
            StyleCard(this.dataCard5, "B", "27393");
            dataCard4.BackColor = Color.FromArgb(170, 50, 80);
            dataCard5.BackColor = Color.FromArgb(40, 50, 170);

            // Chart Card
            this.dataCard6.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.dataCard6.Dock = DockStyle.Fill;
            this.dataCard6.Margin = new Padding(10);
            this.dataCard6.Controls.Add(this.chart1);

            // Chart
            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("MainArea");
            chartArea.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.chart1.ChartAreas.Add(chartArea);
            this.chart1.Dock = DockStyle.Fill;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Data");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series.Points.AddXY("A", 40);
            series.Points.AddXY("B", 35);
            series.Points.AddXY("C", 25);
            this.chart1.Series.Add(series);
            this.chart1.ForeColor = System.Drawing.Color.White;

            // Add cards to layout
            this.dashboardLayout.Controls.Add(this.dataCard1, 0, 0);
            this.dashboardLayout.Controls.Add(this.dataCard2, 1, 0);
            this.dashboardLayout.Controls.Add(this.dataCard3, 2, 0);
            this.dashboardLayout.Controls.Add(this.dataCard4, 0, 1);
            this.dashboardLayout.Controls.Add(this.dataCard5, 1, 1);
            this.dashboardLayout.Controls.Add(this.dataCard6, 2, 1);

            contentPanel.Controls.Add(dashboardLayout);
        }



        private void Main_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = currentEmployee.first_name + " " + currentEmployee.last_name;

            Button homeBtn = new Button();
            Button tablesBtn = new Button();
            Button graphsBtn = new Button();

            StyleSidebarButton(homeBtn, "Home");
            StyleSidebarButton(tablesBtn, "Tables");
            StyleSidebarButton(graphsBtn, "Graphs");

            //homeBtn.Click += homeBtn_Click;
            tablesBtn.Click += tablesBtn_Click;
            graphsBtn.Click += graphsBtn_Click;

            StyleSpecialButton(homeBtn, Color.FromArgb(90, 60, 170));

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
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(90, 60, 90); // ButtonHoverColor
            button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
        }

        private static void StyleSpecialButton(Button button, Color color)
        {
            button.BackColor = color;
            button.MouseEnter += (s, e) => button.BackColor = color; // ButtonHoverColor
            button.MouseLeave += (s, e) => button.BackColor = color;
        }

        //private void homeBtn_Click(object sender, EventArgs e)
        //{
        //    FormController.CreateForm(new Main(), false, true);
        //    this.Hide();
        //}

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            FormController.CreateForm(new Tables(), false, true);
            this.Hide();
        }

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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
