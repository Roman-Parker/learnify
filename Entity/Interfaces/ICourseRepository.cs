using Systems.Threading.Tasks;
using Systems.Collections.Generic;

namespace Entity.Interfaces
{
    public interface ICourseRepository 
    {
        Task<Course> GetCourseByIdAsync(int id);

        Task<IReadOnlyList<Course>> GetCoursesAsync();
    }
}