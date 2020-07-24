using AutoMapper;
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
    public class TagViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ITagRepository _tagRepository;

        public TagViewComponent(IMapper mapper,
                                 ITagRepository tagRepository)
        {
            _mapper = mapper;
            _tagRepository = tagRepository;
        }

        public IViewComponentResult Invoke()
        {
            var tag = _tagRepository.GetTags();

            var model = _mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tag);

            return View(model);
        }
    }
}
