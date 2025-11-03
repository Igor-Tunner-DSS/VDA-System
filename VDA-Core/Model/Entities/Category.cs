using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class Category
    {
        public int category_id { get; private set; }
        public string name { get; private set; }
        public string? description { get; private set; }
        public int? parent_category_id { get; private set; }

        public Category(int category_id, string name, string? description, int? parent_category_id)
        {
            this.category_id = category_id;
            this.name = name;
            this.description = description;
            this.parent_category_id = parent_category_id;
        }
    }
}
