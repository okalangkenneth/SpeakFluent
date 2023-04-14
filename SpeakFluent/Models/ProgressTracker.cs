using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class ProgressTracker
    {
        public int ProgressTrackerId { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int LessonsCompleted { get; set; }
        public int TotalScore { get; set; }
    }
}
