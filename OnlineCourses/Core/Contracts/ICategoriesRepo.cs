using OnlineCourses.Contracts;
using OnlineCourses.Domain;

namespace OnlineCourses.Core.Contracts
{
    public interface ICategoriesRepo : IAsyncRepo<Category>
    {
        Task<IReadOnlyList<Category>> GetCategoriesAsync();
    }
}
