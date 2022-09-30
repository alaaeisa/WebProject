using MediatR;
using OnlineCourses.Domain;
using System;

namespace OnlineCourses.Core.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest<Guid>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ReelLink { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public List<CourseVideo> Video { get; set; }
    }
}
