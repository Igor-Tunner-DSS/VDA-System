using VDA_Application.Model;

namespace VDA_Application
{
    public partial class InitForm : Form
    {
        private readonly DatabaseContext _db = new DatabaseContext();
        public InitForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            List<Employee> employees = await _db.GetEmployees();
            dataGridView1.DataSource = employees;
        }
    }
}
