using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCreation.Entities
{
    public class Product : BaseEntity
    {
        // Reference the category entity
        public Category Category{ get; set; }
        public decimal Price { get; set; }
    }
}
