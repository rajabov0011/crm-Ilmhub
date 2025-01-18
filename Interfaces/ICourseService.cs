using crm_Ilmhub.Models;

namespace crm_Ilmhub.Interfaces;

public interface ICourseService
{
    ValueTask<IEnumerable<Course>> GetCoursesAsync(CancellationToken cancellationToken = default);
    ValueTask<Course?> GetCourseByIdAsync(int id, CancellationToken cancellationToken = default);
    ValueTask<Course> CreateCourseAsync(Course course, CancellationToken cancellationToken = default);
    ValueTask<Course> UpdateCourseAsync(Course course, CancellationToken cancellationToken = default);
    ValueTask<bool> DeleteCourseAsync(int id, CancellationToken cancellationToken = default);
}