using VDA_Application.Model;
using VDA_Application.Controller;

namespace VDA_Application
{
    public partial class InitForm : Form
    {
        private readonly DataGridViewController _controller = new DataGridViewController();
        public InitForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            _controller.ShowData<Employee>(dataGridView1);
        }
    }
}
