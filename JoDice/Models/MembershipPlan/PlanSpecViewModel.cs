using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.Models.MembershipPlan
{
    public class PlanSpecViewModel
    {
        public string Value { get; set; }
        public ICollection<MembershipPlanViewModel> Memberships  { get; set; }
    }
}
