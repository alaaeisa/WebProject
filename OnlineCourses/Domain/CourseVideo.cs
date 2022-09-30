namespace OnlineCourses.Domain
{
    public class CourseVideo
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public string Link { get; set; }

    }
}
