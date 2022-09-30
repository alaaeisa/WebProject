using System;

namespace OnlineCourses.Core.Features.Courses.Queries.GetCoursesList
{
    public class GetCoursesListViewModel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ReelLink { get; set; }
        public CategoryDto Category { get; set; }
    }
}
