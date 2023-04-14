using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<ProgressTracker> ProgressTrackers { get; set; }
    }
}
