using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JoDice.Models;
using JoDice.Models.Account;
using JoDice.Models.Job;
using JoDice.Models.MembershipPlan;
using Repository.Models;

namespace JoDice.Mapping
{
    public class MappingProfile  :Profile
    {
        public MappingProfile()
        {
            CreateMap<Partner, PartnerViewModel>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<Tag, TagViewModel>();
            CreateMap<MembershipPlan, MembershipPlanViewModel>();
            CreateMap<PlanSpec, PlanSpecViewModel>();
            CreateMap<RegisterViewModel, User>();
            CreateMap<CompanyViewModel, Company>();
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Job, JobViewModel>();
            CreateMap<Country, CountryViewModel>();
        }
    }
}
