using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class UserInteraction
    {
        public int UserInteractionId { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string InteractionType { get; set; }
        public DateTime InteractionDate { get; set; }
    }
}
