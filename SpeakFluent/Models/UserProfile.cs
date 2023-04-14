namespace SpeakFluent.Models
{
    public class UserProfile
    {
        public string UserProfileId { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string NativeLanguage { get; set; }
        public string LearningLanguage { get; set; }
        public int FluencyLevel { get; set; }
        public string LearningGoal { get; set; }
    }
}
