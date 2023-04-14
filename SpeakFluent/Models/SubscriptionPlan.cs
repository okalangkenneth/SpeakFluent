using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class SubscriptionPlan
    {
        public int SubscriptionPlanId { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }

}
