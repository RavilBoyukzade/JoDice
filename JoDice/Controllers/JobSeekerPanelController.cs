using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JoDice.Models.Job;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.JobRepository;

namespace JoDice.Controllers
{
    public class JobSeekerPanelController : Controller
    {
        private readonly JoDiceDbContext _context;
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;

        public JobSeekerPanelController(JoDiceDbContext context,
                              IMapper mapper,
                              IJobRepository jobRepository)
        {
            _context = context;
            _mapper = mapper;
           _jobRepository = jobRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = new JobViewModel
            {
                Jobs = _context.Jobs
            };

            return View(model);
        }

        public IActionResult JobSingle(int id)
        {
            var job = _jobRepository.GetJobById(id);
            if (job == null)
                return NotFound();
            var model = _mapper.Map<Job, JobViewModel>(job);
            return View(model);
        }
        public IActionResult JobDashboard()
        {
            return View();
        }
        public IActionResult StarredJob()
        {
            return View();
        }
        public IActionResult UpdateProfil()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
