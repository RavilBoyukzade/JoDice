using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Company :BaseEntity
    {
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int WorkFrom { get; set; }
    }
}
