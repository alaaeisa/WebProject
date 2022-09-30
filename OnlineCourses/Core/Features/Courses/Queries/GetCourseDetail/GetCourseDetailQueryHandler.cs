using AutoMapper;
using MediatR;
using OnlineCourses.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Features.Courses.Queries.GetCourseDetail
{
    public class GetCourseDetailQueryHandler : IRequestHandler<GetCourseDetailQuery, GetCourseDetailViewModel>
    {
        private readonly ICourseRepo _CourseRepository;
        private readonly IMapper _mapper;

        public GetCourseDetailQueryHandler(ICourseRepo CourseRepository, IMapper mapper)
        {
            _CourseRepository = CourseRepository;
            _mapper = mapper;
        }
        public async Task<GetCourseDetailViewModel> Handle(GetCourseDetailQuery request, CancellationToken cancellationToken)
        {
            var Course = await _CourseRepository.GetCourseByIdAsync(request.CourseId, true);

            return _mapper.Map<GetCourseDetailViewModel>(Course);
        }
    }
}
