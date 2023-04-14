using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string Content { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Bookmark> Bookmarks { get; set; }
        public ICollection<PracticeExercise> PracticeExercises { get; set; }
    }
}
