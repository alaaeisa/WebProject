using MediatR;
using OnlineCourses.Core.DTO;

namespace OnlineCourses.Core.Features.Categories.Queries.GetCategoryDetail
{
    public class GetCategoryDetailQuery : IRequest<DropDownDataDTO>
    {
        public Guid CategoryID { get; set; }
    }
}
