using MediatR;
using System;

namespace OnlineCourses.Core.Features.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

    }
}
