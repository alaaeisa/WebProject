using AutoMapper;
using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Features.Categories.Queries.GetCategoryDetail;
using OnlineCourses.Core.Features.Commands.DeleteCourse;
using OnlineCourses.Core.Features.Courses.Commands.CreateCategory;
using OnlineCourses.Core.Features.Courses.Commands.CreateCourse;
using OnlineCourses.Core.Features.Courses.Commands.UpdateCourse;
using OnlineCourses.Core.Features.Courses.Queries.GetCourseDetail;
using OnlineCourses.Core.Features.Courses.Queries.GetCoursesList;
using OnlineCourses.Core.Features.Courses.Queries.GetCoursesList;
using OnlineCourses.Domain;

namespace OnlineCourses.Core.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Course, GetCoursesListViewModel>().ReverseMap();
            CreateMap<Course, GetCourseDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, DropDownDataDTO>().ReverseMap();
            CreateMap<Course, CreateCourseCommand>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Course, UpdateCourseCommand>().ReverseMap();
            CreateMap<Course, DeleteCourseCommand>().ReverseMap();
        }
    }
}
