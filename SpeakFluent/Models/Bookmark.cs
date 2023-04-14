using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class Bookmark
    {
        public int BookmarkId { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }

}
