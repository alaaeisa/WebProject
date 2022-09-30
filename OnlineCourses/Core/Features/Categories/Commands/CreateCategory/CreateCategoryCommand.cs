using MediatR;
using OnlineCourses.Domain;
using System;

namespace OnlineCourses.Core.Features.Courses.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
