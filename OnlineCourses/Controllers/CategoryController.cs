using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Core.Features.Courses.Commands.CreateCategory;

namespace OnlineCourses.Controllers
{
    public class CategoryController : Controller
    {
        // Category
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {

            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            CreateCategoryCommand CategoryCommand = new CreateCategoryCommand();
            CategoryCommand.ID = Guid.NewGuid();
            CategoryCommand.Name = "Adult";
            Guid id = await _mediator.Send(CategoryCommand);
            // return Ok(id);
            return View();
        }
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCategoryCommand createCourseCommand)
        {
            Guid id = await _mediator.Send(createCourseCommand);
            return Ok(id);
        }

       
    }
}
