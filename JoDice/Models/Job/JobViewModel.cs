using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace JoDice.Models.Job
{
    public class JobViewModel
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public JobType JobType { get; set; }
        public string Salary { get; set; }
        public string Adress { get; set; }
        public DateTime AddedDate { get; set; }
        public string JobAbout { get; set; }
        public string JobTitle { get; set; }
        public List<CountryViewModel> Countries { get; set; }
    }
}
