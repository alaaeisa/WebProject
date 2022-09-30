
using AutoMapper;
using MediatR;
using OnlineCourses.Contracts;
using OnlineCourses.Domain;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace OnlineCourses.Core.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ICourseRepo _CourseRepository;
        private readonly IMapper _mapper;

        public CreateCourseCommandHandler(ICourseRepo CourseRepository, IMapper mapper)
        {
            _CourseRepository = CourseRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            Course _CourseObj = _mapper.Map<Course>(request);

            CreateCommandValidator validator = new CreateCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Course is not valid");
            }

            _CourseObj = await _CourseRepository.AddAsync(_CourseObj);

            return _CourseObj.ID;
        }
    }
}
