using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDA_Application.Model;

namespace VDA_Application.Controller
{
    public class DataGridViewController
    {
        private readonly DatabaseContext _db = new DatabaseContext();
        public DataGridViewController() { }

        public async void ShowData<T>(DataGridView dataGridView)
        {
            if (typeof(T) == typeof(Employee))
            {
                var dataSource = await _db.GetEmployees();
                dataGridView.DataSource = dataSource;
            }
            else
            {
                return;
            }

        }
    }   
}
