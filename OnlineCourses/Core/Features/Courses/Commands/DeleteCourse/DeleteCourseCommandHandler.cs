
using MediatR;
using OnlineCourses.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Features.Commands.DeleteCourse
{
    public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand>
    {
        private readonly ICourseRepo _CourseRepository;
        public DeleteCourseCommandHandler(ICourseRepo CourseRepository)
        {
            _CourseRepository = CourseRepository;
        }

        public async Task<Unit> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var Course = await _CourseRepository.GetByIdAsync(request.CourseId);

            await _CourseRepository.DeleteAsync(Course);

            return Unit.Value;
        }
    }

}
