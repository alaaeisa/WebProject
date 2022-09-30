namespace OnlineCourses.Domain
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Description { get; set; }
    }
}
