namespace OnlineCourses.Domain
{
    public class Subscription
    {
        public Guid ID { get; set; }
        public Guid CustomerID  { get; set; }
        public Guid CourseID { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}
