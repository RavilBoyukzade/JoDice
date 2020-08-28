using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PlanSpec :BaseEntity
    {
        public int OrderBy { get; set; }
        public int MembershipPlanId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Value { get; set; }
        public MembershipPlan MembershipPlan { get; set; }
    }
}
