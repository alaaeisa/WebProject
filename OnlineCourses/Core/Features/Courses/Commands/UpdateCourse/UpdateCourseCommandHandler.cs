using AutoMapper;

using MediatR;
using OnlineCourses.Contracts;
using OnlineCourses.Domain;
using System.Threading;
using System.Threading.Tasks;


namespace OnlineCourses.Core.Features.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand>
    {
        private readonly ICourseRepo _CourseRepository;
        private readonly IMapper _mapper;
     
        public UpdateCourseCommandHandler(ICourseRepo CourseRepository, IMapper mapper)
        {
            _CourseRepository = CourseRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            Course CourseObj = _mapper.Map<Course>(request);

            await _CourseRepository.UpdateAsync(CourseObj);

            return Unit.Value;
        }
    }
}
