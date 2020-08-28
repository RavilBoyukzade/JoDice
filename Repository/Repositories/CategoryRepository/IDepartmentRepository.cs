using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.CategoryRepository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartmentsWithCategories();
        IEnumerable<Department> GetPopularCategory(int limit);
    }

    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly JoDiceDbContext _context;

        public DepartmentRepository(JoDiceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetDepartmentsWithCategories()
        {
            return _context.Departments.Include("Categories")
                                       .Where(d => d.Status)
                                       .ToList();
                                       
        }

        public IEnumerable<Department> GetPopularCategory(int limit)
        {
            return _context.Departments.Include("Categories")
                                       .Where(s => s.Status)
                                       .Where(p => p.IsPopular)
                                       .OrderByDescending(d => d.AddedDate)
                                       .Take(limit)
                                       .ToList();
        }
    }

}
