using Microsoft.EntityFrameworkCore;
using Valhalla.Domain.Courses;

namespace Valhalla.Application.Abstractions.EntityFramework
{
    public interface IValhallaContext
    {
        DbSet<Course> Course { get; set; }
    }
}
