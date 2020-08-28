using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
