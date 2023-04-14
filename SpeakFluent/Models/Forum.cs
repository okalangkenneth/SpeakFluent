using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class Forum
    {
        public int ForumId { get; set; }
        public string Title { get; set; }
        public ICollection<Discussion> Discussions { get; set; }
        
    }
}
