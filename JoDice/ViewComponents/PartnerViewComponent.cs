using AutoMapper;
using JoDice.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.ViewComponents
{
    public class PartnerViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public PartnerViewComponent (IMapper mapper,
                                    IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var partner = _contentRepository.GetPartners();
            var model = _mapper.Map<IEnumerable<Partner>, IEnumerable<PartnerViewModel>>(partner);

            return View(model);
        }
    }
}
