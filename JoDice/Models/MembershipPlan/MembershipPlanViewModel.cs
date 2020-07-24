using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace JoDice.Models.MembershipPlan
{
    public class MembershipPlanViewModel
    {
        public string PlanCategoryName { get; set; }
        public string Description { get; set; }
        public PlanPrice PlanPrice { get; set; }

        public string ActionName { get; set; }
        public string EndPoint { get; set; }
        public IList<PlanSpecViewModel> Plans { get; set; }
        public IList<DiscountViewModel> Discounts { get; set; }

    }
}
