using VDA_Core.Model;
using VDA_Core.Controller;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using VDA_Application.Properties;

namespace VDA_Application
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            // ===== FORM =====
            this.BackColor = Color.FromArgb(10, 25, 47); // dark blue gradient base
            this.FormBorderStyle = FormBorderStyle.None; // clean edges
            this.StartPosition = FormStartPosition.CenterScreen;

            // ===== PANEL 3 (Left - Welcome section) =====
            panel3.BackColor = Color.FromArgb(15, 76, 129);
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.None;

            // Create gradient effect using Paint event
            panel3.Paint += (s, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel3.ClientRectangle,
                    Color.FromArgb(80, 40, 200),
                    Color.FromArgb(70, 20, 100),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel3.ClientRectangle);
                }
            };

            // ===== PANEL 2 (Right - Login background) =====
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.None;

            // ===== PANEL 1 (Login form content) =====
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Padding = new Padding(25);
            panel1.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));

            // ===== LABELS =====
            emailLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(50, 50, 50);

            passwordLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(50, 50, 50);

            idLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            idLabel.ForeColor = Color.FromArgb(50, 50, 50);

            // ===== TEXTBOXES =====
            StyleTextBox(loginBox);
            StyleTextBox(passwordBox);
            StyleTextBox(idBox);

            // ===== BUTTONS =====
            StylePrimaryButton(loginButton, Color.FromArgb(144, 30, 255), Color.FromArgb(0, 122, 204));


        }

        // Rounded corners and text styling
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void StyleTextBox(TextBox box)
        {
            box.BorderStyle = BorderStyle.FixedSingle;
            box.BackColor = Color.White;
            box.ForeColor = Color.Black;
            box.Font = new Font("Segoe UI", 10);
            box.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, box.Width, box.Height, 5, 5));
        }

        private void StylePrimaryButton(Button btn, Color top, Color bottom)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 8, 8));
            btn.BackColor = top;

            /*btn.Paint += (s, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    btn.ClientRectangle, top, bottom, LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }
            };*/
        }

        private void StyleSecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btn.ForeColor = Color.FromArgb(0, 122, 204);
            btn.BackColor = Color.White;
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 8, 8));
        }



        private async void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string id = idBox.Text.Trim();

            bool validated = await AuthController.ValidateCredentials(login, password, id);
            if (validated)
            {
                FormController.CreateForm(new Main(), false, true);
                this.Hide();
            }
        }

        private void InitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
