using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepository
{
    public interface IContentRepository
    {
        IEnumerable<Partner> GetPartners();
        IEnumerable<MembershipPlan> GetPlans();
    }

    public class ContentRepository : IContentRepository
    {
        private readonly JoDiceDbContext _context;

        public ContentRepository(JoDiceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Partner> GetPartners()
        {
            return _context.Partners.OrderByDescending(p => p.AddedDate)
                                    .ToList();
        }

        public IEnumerable<MembershipPlan> GetPlans()
        {
            return _context.MembershipPlans.Where(b => b.Status)
                                           .Include("PlanSpecs")
                                           .OrderBy(m => m.PlanPrice)
                                           .ToList();
        }
    }
}
