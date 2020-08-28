using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class MembershipPlan:BaseEntity
    {
        public string PlanCategoryName { get; set; }
        public string Description { get; set; }
        public PlanPrice PlanPrice { get; set; }
        public string ActionName { get; set; }
        public string EndPoint { get; set; }
        public ICollection<PlanSpec> PlanSpecs { get; set; }
    }
}
