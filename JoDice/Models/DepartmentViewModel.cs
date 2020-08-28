using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace JoDice.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string IconImage { get; set; }
        public string Name { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
