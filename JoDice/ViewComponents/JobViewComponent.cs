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
    public class JobViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;

        public JobViewComponent(IMapper mapper,
                                IJobRepository jobRepository)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }

        public IViewComponentResult Invoke()
        {
            var job = _jobRepository.GetFuturedJob(6);
            var model =  _mapper.Map<IEnumerable<Job>, IEnumerable<JobViewModel>>(job);

            return View(model);



        }
    }
}
