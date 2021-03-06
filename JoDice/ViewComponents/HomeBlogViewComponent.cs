﻿using AutoMapper;
using JoDice.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.BlogRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.ViewComponents
{
    public class HomeBlogViewComponent: ViewComponent
    {
       
            private readonly IMapper _mapper;
            private readonly IBlogRepository _blogRepository;

            public HomeBlogViewComponent(IMapper mapper,
                                      IBlogRepository blogRepository)
            {
                _mapper = mapper;
                _blogRepository = blogRepository;
            }

            public IViewComponentResult Invoke()
            {
                var blog = _blogRepository.GetNewPostedBlog(3);

                var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogViewModel>>(blog);

                return View(model);
            }
        
    }
}
