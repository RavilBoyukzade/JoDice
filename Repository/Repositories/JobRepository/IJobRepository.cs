using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.JobRepository
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetFuturedJob(int limit);
    }

    public class JobRepository : IJobRepository
    {
        private readonly JoDiceDbContext _context;

        public JobRepository(JoDiceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Job> GetFuturedJob(int limit)
        {
            return _context.Jobs
                                .Where(f => f.Status)
                                .Where(f => f.IsFeatured)
                                .OrderByDescending(f=>f.AddedDate)
                                .Take(limit)
                                .ToList();
        }
    }
}
