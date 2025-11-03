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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            sidebarPanel.SuspendLayout();
            logoutPanel.SuspendLayout();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            titleLabel.Size = new Size(281, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Graphs and Statistics";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(20, 20, 30);
            contentPanel.Controls.Add(chart1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(257, 100);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(14, 17, 14, 17);
            contentPanel.Size = new Size(1226, 925);
            contentPanel.TabIndex = 0;
            // 
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(80, 80, 120);
            chart1.BorderlineColor = Color.FromArgb(85, 85, 125);
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 4;
            chart1.BorderSkin.PageColor = Color.FromArgb(40, 40, 60);
            chartArea1.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisX.LineColor = Color.White;
            stripLine1.ForeColor = Color.BlanchedAlmond;
            stripLine1.Text = "a";
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX2.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisX2.LineColor = Color.White;
            chartArea1.AxisX2.LineWidth = 4;
            chartArea1.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY.LineColor = Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY2.LineColor = Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = Color.White;
            chartArea1.AxisY2.MajorTickMark.LineColor = Color.BlanchedAlmond;
            chartArea1.AxisY2.MinorGrid.LineColor = Color.BlanchedAlmond;
            chartArea1.AxisY2.MinorTickMark.LineColor = Color.BlanchedAlmond;
            chartArea1.AxisY2.TitleForeColor = Color.White;
            chartArea1.BackColor = Color.FromArgb(40, 40, 60);
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea1.BackImageTransparentColor = Color.FromArgb(40, 40, 60);
            chartArea1.BackSecondaryColor = Color.FromArgb(60, 60, 80);
            chartArea1.BorderColor = Color.FromArgb(60, 60, 80);
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = Color.FromArgb(244, 244, 0, 0);
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Title = "Revenue (in million US$)";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(14, 17);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Customers";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Companies";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "Total";
            series3.Name = "Total";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(1198, 891);
            chart1.TabIndex = 0;
            chart1.Text = "Revenue Chart";
            title1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            title1.ForeColor = Color.White;
            title1.Name = "Revenue Statistics";
            title1.Text = "Revenue Statistics";
            chart1.Titles.Add(title1);
            chart1.Click += chart1_Click;
            // 
            // Graphs
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
            Name = "Graphs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphs - VDA Application";
            FormClosed += Graphs_FormClosed;
            Load += Graphs_Load;
            sidebarPanel.ResumeLayout(false);
            logoutPanel.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}