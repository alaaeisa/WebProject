using Microsoft.EntityFrameworkCore;
using OnlineCourses.Domain;
using System.Data;

namespace OnlineCourses.Infrastructure.Persistence
{
    public class OnlineCoursesDbContext : DbContext
    {

        public OnlineCoursesDbContext(DbContextOptions<OnlineCoursesDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<CourseVideo> CourseVideo { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
