using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.AuthRepository;
using Repository.Repositories.BlogRepository;
using Repository.Repositories.CategoryRepository;
using Repository.Repositories.CompanyRepository;
using Repository.Repositories.ContentRepository;
using Repository.Repositories.JobRepository;

namespace JoDice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<JoDiceDbContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("Default"),
                  x => x.MigrationsAssembly("Repository")));

            services.AddTransient<IContentRepository, ContentRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IJobRepository, JobRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
           

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
