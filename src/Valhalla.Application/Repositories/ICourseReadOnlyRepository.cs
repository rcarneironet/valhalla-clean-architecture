using System.Collections.Generic;
using System.Threading.Tasks;
using Valhalla.Domain.Courses;

namespace Valhalla.Application.Repositories
{
    public interface ICourseReadOnlyRepository
    {
        Task<IEnumerable<Course>> List();
    }
}
