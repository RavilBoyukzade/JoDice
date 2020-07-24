using AutoMapper;
using JoDice.Models.MembershipPlan;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.ViewComponents
{
    public class MembershipViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public MembershipViewComponent(IMapper mapper,
                                       IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var plan = _contentRepository.GetPlans();

            var model = _mapper.Map<IEnumerable<MembershipPlan>, IEnumerable<MembershipPlanViewModel>>(plan);
            return View(model);
        }
    }
}
