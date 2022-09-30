using AutoMapper;
using MediatR;
using OnlineCourses.Contracts;
using OnlineCourses.Core.Contracts;
using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Features.Courses.Queries.GetCourseDetail;

namespace OnlineCourses.Core.Features.Categories.Queries.GetCategoryDetail
{
    public class GetCategoryDetailQueryHandler : IRequestHandler<GetCategoryDetailQuery, DropDownDataDTO>
    {

        private readonly ICategoriesRepo _CategoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryDetailQueryHandler(ICategoriesRepo CourseRepository, IMapper mapper)
        {
            _CategoryRepository = CourseRepository;
            _mapper = mapper;
        }
        public async Task<DropDownDataDTO> Handle(GetCategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var Category = await _CategoryRepository.GetByIdAsync(request.CategoryID);

            return _mapper.Map<DropDownDataDTO>(Category);
        }
    }
}
