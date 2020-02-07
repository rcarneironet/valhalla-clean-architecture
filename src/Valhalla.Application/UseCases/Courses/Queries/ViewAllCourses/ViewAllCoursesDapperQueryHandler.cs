using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Valhalla.Application.Repositories;

namespace Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses
{
    public class ViewAllCoursesDapperQueryHandler : IRequestHandler<ViewAllCoursesDapperQuery, ViewAllCoursesViewModel>
    {
        private readonly ICourseReadOnlyRepository _courseRepository;

        public ViewAllCoursesDapperQueryHandler(ICourseReadOnlyRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<ViewAllCoursesViewModel> Handle(
            ViewAllCoursesDapperQuery request,
            CancellationToken cancellationToken)
        {
            return new ViewAllCoursesViewModel
            {
                Courses = await _courseRepository.List()
            };
        }
    }
}
