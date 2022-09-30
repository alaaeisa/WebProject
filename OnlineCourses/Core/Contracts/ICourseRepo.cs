
using OnlineCourses.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Contracts
{
    public interface ICourseRepo : IAsyncRepo<Course>
    {

        Task<IReadOnlyList<Course>> GetAllCoursesAsync(bool IncludeCat);
        Task<Course> GetCourseByIdAsync(Guid Id,bool IncludeCat);
    }
}
