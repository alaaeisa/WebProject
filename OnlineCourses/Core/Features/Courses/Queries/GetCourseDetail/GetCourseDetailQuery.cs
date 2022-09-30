using MediatR;
using System;

namespace OnlineCourses.Core.Features.Courses.Queries.GetCourseDetail
{
    public class GetCourseDetailQuery : IRequest<GetCourseDetailViewModel>
    {
        public Guid CourseId { get; set; }
    }
}
