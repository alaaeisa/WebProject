using AutoMapper;
using MediatR;
using OnlineCourses.Contracts;
using OnlineCourses.Core.Features.Courses.Queries.GetCoursesList;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Features.Courses.Queries.GetCoursesList
{
    public class GetCoursesListQueryHandler : IRequestHandler<GetCoursesListQuery, List<GetCoursesListViewModel>>
    {
        private readonly ICourseRepo _CourseRepository;
        private readonly IMapper _mapper;

        public GetCoursesListQueryHandler(ICourseRepo CourseRepository, IMapper mapper)
        {
            _CourseRepository = CourseRepository;
            _mapper = mapper;
        }
        public async Task<List<GetCoursesListViewModel>> Handle(GetCoursesListQuery request, CancellationToken cancellationToken)
        {
            var allCourses = await _CourseRepository.GetAllCoursesAsync(true);
            return _mapper.Map<List<GetCoursesListViewModel>>(allCourses);
        }
    }
}
