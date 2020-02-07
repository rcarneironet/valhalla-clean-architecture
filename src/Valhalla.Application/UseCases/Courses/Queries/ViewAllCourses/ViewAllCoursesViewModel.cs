using System.Collections.Generic;
using Valhalla.Domain.Courses;

namespace Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses
{
    public class ViewAllCoursesViewModel
    {
        public IList<Course> Courses { get; set; }
    }
}
