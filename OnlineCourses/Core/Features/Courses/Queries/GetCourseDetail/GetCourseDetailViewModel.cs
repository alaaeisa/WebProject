
using System;

namespace OnlineCourses.Core.Features.Courses.Queries.GetCourseDetail
{
    public class GetCourseDetailViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
    }
}
