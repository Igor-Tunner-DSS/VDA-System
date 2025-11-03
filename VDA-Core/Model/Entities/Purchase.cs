using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class Purchase
    {
        public int purchase_id { get; private set; }
        public int customer_id { get; private set; }
        public int employee_id { get; private set; }
        public float total_price { get; private set; }
        public DateOnly? purchase_date {  get; private set; }
        public DateOnly? shipped_date { get; private set; }
        public string? ship_address { get; private set; }
        public string? ship_city { get; private set; }
        public string? ship_country { get; private set; }

        public Purchase(int purchase_id, int customer_id, int employee_id, float total_price, DateOnly? purchase_date = null, DateOnly? shipped_date = null, string? ship_address = null, string? ship_city = null, string? ship_country = null)
        {
            this.purchase_id = purchase_id;
            this.customer_id = customer_id;
            this.employee_id = employee_id;
            this.total_price = total_price;
            this.purchase_date = purchase_date;
            this.shipped_date = shipped_date;
            this.ship_address = ship_address;
            this.ship_city = ship_city;
            this.ship_country = ship_country;
        }
    }
}
