using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class Employee
    {
        public int id { get; private set; }
        public string first_name { get; private set; }
        public string last_name { get; private set; }
        public DateOnly? birth_date { get; private set; }
        public DateOnly? hire_date { get; private set; }
        public string? address { get; private set; }
        public string? city { get; private set; }
        public string? country { get; private set; }
        public int? reports_to { get; private set; }

        public Employee(int id, string last_name, string first_name, DateOnly? birth_date, DateOnly? hire_date, string? address, string? city, string? country, int? reports_to)
        {
            this.id = id;
            this.last_name = last_name;
            this.first_name = first_name;
            this.birth_date = birth_date;
            this.hire_date = hire_date;
            this.address = address;
            this.city = city;
            this.country = country;
            this.reports_to = reports_to;
        }
    }
}
