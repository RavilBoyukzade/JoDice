using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.CompanyRepository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies();
    }

    public class CompanyRepository : ICompanyRepository
    {
        private readonly JoDiceDbContext _context;

        public CompanyRepository(JoDiceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Company> GetCompanies()
        {
            return _context.Companies.Where(s => s.Status)
                                     .ToList();
        }
    }
}
