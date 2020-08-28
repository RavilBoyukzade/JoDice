using AutoMapper;
using JoDice.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.ViewComponents
{
    public class PopularCategViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;

        public PopularCategViewComponent(IMapper mapper,
                                          IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var popular = _departmentRepository.GetPopularCategory(8);

            var model = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(popular);

            return View(model);
        }
    }
}
