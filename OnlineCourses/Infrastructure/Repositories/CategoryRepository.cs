using Microsoft.EntityFrameworkCore;
using OnlineCourses.Contracts;
using OnlineCourses.Core.Contracts;
using OnlineCourses.Domain;
using OnlineCourses.Infrastructure.Persistence;

namespace OnlineCourses.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoriesRepo
    {
        public CategoryRepository(OnlineCoursesDbContext CoursesDbContext) : base(CoursesDbContext)
        {

        }

        public async Task<IReadOnlyList<Category>> GetCategoriesAsync()
        {
            List<Category> allPosts = new List<Category>();
            allPosts =  await _dbContext.Category.ToListAsync();
            return allPosts;
        }
    }
}
