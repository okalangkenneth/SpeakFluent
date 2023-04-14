using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakFluent.Models
{
    public class PracticeExercise
    {
        public int PracticeExerciseId { get; set; }
        public string ExerciseType { get; set; }
        public string Content { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
