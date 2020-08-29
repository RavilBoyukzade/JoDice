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
        IEnumerable<Job> GetJob();
        Job GetJobById(int id);
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
            return _context.Jobs.Include("Countries")
                                .Where(f => f.Status)
                                .Where(f => f.IsFeatured)
                                .OrderByDescending(f=>f.AddedDate)
                                .Take(limit)
                                .ToList();
        }

        public IEnumerable<Job> GetJob()
        {
            return _context.Jobs.Where(s => s.Status)
                                .ToList();
        }

        public Job GetJobById(int id)
        {
            return _context.Jobs.Find(id);
        }
    }
}
