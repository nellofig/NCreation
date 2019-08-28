using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCreation.Entities
{
    // Base Entity to take care of common Model objects which will be repeated mostly in all entities.
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string User { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
