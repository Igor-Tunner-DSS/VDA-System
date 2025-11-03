using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDA_Core.Model;
using VDA_Core.Model.Entities;

namespace VDA_Core.Controller
{
    public class DataGridViewController
    {
        private static readonly DatabaseContext _db = new DatabaseContext();

        public static async void ShowData<T>(DataGridView dataGridView)
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
