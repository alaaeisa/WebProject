using MediatR;
using System;

namespace OnlineCourses.Core.Features.Commands.DeleteCourse
{
    public class DeleteCourseCommand : IRequest
    {
        public Guid CourseId { get; set; }
    }

}
