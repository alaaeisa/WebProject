using FluentValidation;

namespace OnlineCourses.Core.Features.Courses.Commands.CreateCourse
{
    public class CreateCommandValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            
           
        }
    }
}
