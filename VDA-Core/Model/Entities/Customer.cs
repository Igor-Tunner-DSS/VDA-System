using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class Customer
    {
        public int id { get; private set; }
        public string contact_name { get; private set; }
        public string? company_name { get; private set; }
        public string contact_email { get; private set; }
        public string? address { get; private set; }
        public string? city { get; private set; }
        public string? country { get; private set; }

        public Customer(int id, string contact_name, string contact_email, string? company_name = null, string? address = null, string? city = null, string? country = null) {
            this.id = id;
            this.contact_name = contact_name;
            this.contact_email = contact_email;
            this.company_name = company_name;
            this.address = address;
            this.city = city;
            this.country = country;
        }
    }
}
