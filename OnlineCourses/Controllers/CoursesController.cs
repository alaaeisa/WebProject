using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Core.Features.Categories.Queries.GetCategoryDetail;
using OnlineCourses.Core.Features.Courses.Commands.CreateCourse;

namespace OnlineCourses.Controllers
{
    public class CoursesController : Controller
    {
     
      
        private readonly IMediator _mediator;
        public CoursesController( IMediator mediator)
        {
            
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var getEventDetailQuery = new GetCategoryDetailQuery() { CategoryID = Guid.Parse("74554376-c83a-4e4d-babb-c96ec904ae38") };
             var  res =await _mediator.Send(getEventDetailQuery);

            CreateCourseCommand CourseCommand = new CreateCourseCommand();
            CourseCommand.CategoryId = res.ID;
            CourseCommand.ID = Guid.NewGuid();
            CourseCommand.Title = " Course";
            CourseCommand.ReelLink = "";
            CourseCommand.Price = 2000;
            CourseCommand.Description = "";
            Guid id = await _mediator.Send(CourseCommand);
           // return Ok(id);
            return View();
        }
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCourseCommand createCourseCommand)
        {
            Guid id = await _mediator.Send(createCourseCommand);
            return Ok(id);
        }

    }
}
