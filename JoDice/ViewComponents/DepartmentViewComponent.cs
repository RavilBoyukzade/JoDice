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
    public class DepartmentViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentViewComponent(IMapper mapper,
                                       IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var department = _departmentRepository.GetDepartmentsWithCategories();

            var model = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(department);

            return View(model);
        }

    }
}
