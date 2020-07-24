using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.BlogRepository
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTags();
    }

    public class TagRepository : ITagRepository
    {
        private readonly JoDiceDbContext _context;

        public TagRepository(JoDiceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Tag> GetTags()
        {
            return _context.Tags.Where(s => s.Status).ToList();
        }
    }
}
