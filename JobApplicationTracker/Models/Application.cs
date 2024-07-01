namespace JobApplicationTracker.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? InterviewDate { get; set; }
    }
}

