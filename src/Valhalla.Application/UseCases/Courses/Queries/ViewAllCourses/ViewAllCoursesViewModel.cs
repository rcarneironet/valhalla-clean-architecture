using System.Collections.Generic;

namespace Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses
{
    public class ViewAllCoursesViewModel
    {
        public IList<CourseListViewModel> Courses { get; set; }
    }
}
