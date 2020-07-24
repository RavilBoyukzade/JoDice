using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class JoDiceDbContext : DbContext
    {
        public JoDiceDbContext(DbContextOptions<JoDiceDbContext>options) : base(options) { }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<MembershipPlan> MembershipPlans { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PlanSpec> PlanSpecs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
