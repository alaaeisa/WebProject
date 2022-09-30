
using AutoMapper;
using MediatR;
using OnlineCourses.Contracts;
using OnlineCourses.Core.Contracts;
using OnlineCourses.Domain;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace OnlineCourses.Core.Features.Courses.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
    {
        private readonly ICategoriesRepo _CategoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoriesRepo CategoryRepository, IMapper mapper)
        {
            _CategoryRepository = CategoryRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category _CourseObj = _mapper.Map<Category>(request);

            //CreateCommandValidator validator = new CreateCommandValidator();
            //var result = await validator.ValidateAsync(request);

            //if (result.Errors.Any())
            //{
            //    throw new Exception("Course is not valid");
            //}

            _CourseObj = await _CategoryRepository.AddAsync(_CourseObj);

            return _CourseObj.ID;
        }
    }
}
