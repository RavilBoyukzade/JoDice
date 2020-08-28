using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.Models
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<TagViewModel> Tags { get; set; }
        public IQueryable<Blog> Blogs { get; set; }
        public string Txt { get; set; }
    }
}
