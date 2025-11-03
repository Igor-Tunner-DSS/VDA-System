using VDA_Core.Model;
using VDA_Core.Controller;

namespace VDA_Application
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormController.CreateForm(new Main(), false, true);
            this.Hide();
        }
    }
}
