

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineCourses.Domain;
using OnlineCourses.Contracts;
using OnlineCourses.Infrastructure.Persistence;

namespace OnlineCourses.Infrastructure.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepo
    {
        public CourseRepository(OnlineCoursesDbContext CoursesDbContext) : base(CoursesDbContext)
        {

        }
        public async Task<IReadOnlyList<Course>> GetAllCoursesAsync(bool includeCategory)
        {
            List<Course> allPosts = new List<Course>();
            allPosts = includeCategory ? await _dbContext.Courses.Include(x => x.Category).ToListAsync() : await _dbContext.Courses.ToListAsync();
            return allPosts;
        }

        public async Task<Course> GetCourseByIdAsync(Guid id, bool includeCategory)
        {
            Course Post = new Course();
            Post = includeCategory ? await _dbContext.Courses.Include(x => x.Category).FirstOrDefaultAsync(x => x.ID == id) : await GetByIdAsync(id);
            return Post;
        }
    }

}
