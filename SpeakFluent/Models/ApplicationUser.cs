using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserProfile UserProfile { get; set; }
        public ICollection<Flashcard> Flashcards { get; set; }
        public ICollection<ProgressTracker> ProgressTrackers { get; set; }
        public ICollection<UserInteraction> UserInteractions { get; set; }
        public ICollection<Bookmark> Bookmarks { get; set; }
        public ICollection<Discussion> Discussions { get; set; }
        public int? SubscriptionPlanId { get; set; }
        public SubscriptionPlan SubscriptionPlan { get; set; }
    }
}
