using MediatR;
using System.Collections.Generic;

namespace OnlineCourses.Core.Features.Courses.Queries.GetCoursesList
{
    public class GetCoursesListQuery : IRequest<List<GetCoursesListViewModel>>
    {

    }
}
