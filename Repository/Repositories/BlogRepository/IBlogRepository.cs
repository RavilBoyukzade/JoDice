using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.BlogRepository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetNewPostedBlog(int limit);
        IEnumerable<Blog> GetBlogs();
        Blog GetBlogById(int id);
    }

    public class BlogRepository : IBlogRepository
    {
        private readonly JoDiceDbContext _context;

        public BlogRepository(JoDiceDbContext context)
        {
            _context = context;
        }

        public Blog GetBlogById(int id)
        {
            return _context.Blogs.Find(id);
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return _context.Blogs.Where(s => s.Status)
                                 .OrderByDescending(d => d.AddedDate)
                                 .ToList();
        }

        public IEnumerable<Blog> GetNewPostedBlog(int limit)
        {
            return _context.Blogs.Where(s => s.Status)
                                 .OrderByDescending(d => d.AddedDate)
                                 .Take(limit)
                                 .ToList();
        }
    }
}
