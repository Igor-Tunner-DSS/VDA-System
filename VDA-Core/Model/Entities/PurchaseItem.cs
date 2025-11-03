using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class PurchaseItem
    {
        public int purchase_id {  get; private set; }
        public int product_id { get; private set; }
        public int quantity { get; private set; }
        public float unit_price { get; private set; }

        public PurchaseItem(int purchase_id, int product_id, int quantity, float unit_price)
        {
            this.purchase_id = purchase_id;
            this.product_id = product_id;
            this.quantity = quantity;
            this.unit_price = unit_price;
        }
    }
}
