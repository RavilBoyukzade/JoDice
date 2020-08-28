using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Korzh.EasyQuery.Linq;
using JoDice.Models;
using AutoMapper;
using Repository.Repositories.BlogRepository;
using Repository.Models;

namespace JoDice.Controllers
{
    public class BlogController : Controller
    {
        private readonly JoDiceDbContext _context;
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;

        public BlogController(JoDiceDbContext context,
                              IMapper mapper,
                              IBlogRepository blogRepository)
        {
            _context = context;
            _mapper = mapper;
            _blogRepository = blogRepository;
        }
        //View of the blog page
        [HttpGet]
        public IActionResult Index()
        {
            var model = new BlogViewModel
            {
                Blogs = _context.Blogs
            };

          return View(model);
        }

        //open single view page of blog by id
        public IActionResult BlogSingle(int id)
        {
            var blog = _blogRepository.GetBlogById(id);
            if (blog == null)
                return NotFound();
            var model = _mapper.Map<Blog,BlogViewModel>(blog);
            return View(model);

        }

       //search blog
       [HttpPost]
        public IActionResult Index(BlogViewModel model)
        {
            
            if (!string.IsNullOrEmpty(model.Txt))
            {
                model.Blogs = _context.Blogs.FullTextSearchQuery(model.Txt);
            }
            else
            {
                model.Blogs = _context.Blogs;
            }
            return View(model);

        }

    }
}
