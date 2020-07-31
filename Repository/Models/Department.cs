using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
