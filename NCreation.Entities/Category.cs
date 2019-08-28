using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NCreation.Entities
{
    public class Category : BaseEntity
    {
        // referencing the product list one category can have many products.
        public List<Product> Products { get; set; }
    }
}
