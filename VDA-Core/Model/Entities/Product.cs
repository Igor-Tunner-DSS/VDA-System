using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class Product
    {
        public int product_id { get; private set; }
        public string product_name { get; private set; }
        public int category_id { get; private set; }
        public int? quantity_per_unit { get; private set; }
        public float? unit_price { get; private set; }
        public int? units_in_stock { get; private set; }
        public bool? discontinued { get; private set; }

        public Product(int product_id, string product_name, int category_id, int? quantity_per_unit, float? unit_price, int? units_in_stock, bool? discontinued)
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.category_id = category_id;
            this.quantity_per_unit = quantity_per_unit;
            this.unit_price = unit_price;
            this.units_in_stock = units_in_stock;
            this.discontinued = discontinued;
        }
    }
}
