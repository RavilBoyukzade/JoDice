using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.Models.Job
{
    public class CompanyViewModel
    {
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int WorkFrom { get; set; }
    }
}
