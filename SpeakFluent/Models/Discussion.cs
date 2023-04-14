using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ForumId { get; set; }
        public Forum Forum { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
