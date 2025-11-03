using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VDA_Core.Controller;
using VDA_Core.Model.Entities;

namespace VDA_Application.View
{
    public partial class Graphs : Form
    {
        Employee currentEmployee = AuthController.currentSession.currentEmployee;
        public Graphs()
        {
            InitializeComponent();
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = currentEmployee.first_name + " " + currentEmployee.last_name;

            Button homeBtn = new Button();
            Button tablesBtn = new Button();
            Button graphsBtn = new Button();

            StyleSidebarButton(homeBtn, "Home");
            StyleSidebarButton(tablesBtn, "Tables");
            StyleSidebarButton(graphsBtn, "Graphs");

            homeBtn.Click += homeBtn_Click;
            tablesBtn.Click += tablesBtn_Click;
            //graphsBtn.Click += graphsBtn_Click;

            StyleSpecialButton(graphsBtn, Color.FromArgb(130, 80, 75));

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

        private void tablesBtn_Click(object sender, EventArgs e)
        {
            FormController.CreateForm(new Tables(), false, true);
            this.Hide();
        }

        //private void graphsBtn_Click(object sender, EventArgs e)
        //{
        //    FormController.CreateForm(new Graphs(), false, true);
        //    this.Hide();
        //}

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AuthController.currentSession = new();
                FormController.CreateForm(new InitForm());
                this.Hide();
            }
        }

        private void Graphs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
