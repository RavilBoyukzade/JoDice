using AutoMapper;
using JoDice.Models.Job;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.JobRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.ViewComponents
{
    public class FeaturedViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;

        public FeaturedViewComponent(IMapper mapper,
                                  IJobRepository jobRepository)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }

        public IViewComponentResult Invoke()
        {
            var jobs = _jobRepository.GetFuturedJob(6);
            var model = _mapper.Map<IEnumerable<Job>, IEnumerable<JobViewModel>>(jobs);

            return View();
        }
    }
}
