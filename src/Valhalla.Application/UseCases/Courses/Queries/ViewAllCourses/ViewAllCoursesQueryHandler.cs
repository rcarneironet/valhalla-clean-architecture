using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Valhalla.Application.Abstractions.EntityFramework;

namespace Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses
{
    public class ViewAllCoursesQueryHandler : IRequestHandler<ViewAllCoursesQuery, ViewAllCoursesViewModel>
    {
        private readonly IValhallaContext _context;

        public ViewAllCoursesQueryHandler(
            IValhallaContext context)
        {
            _context = context;
        }

        public async Task<ViewAllCoursesViewModel> Handle(
            ViewAllCoursesQuery request,
            CancellationToken cancellationToken)
        {

            return new ViewAllCoursesViewModel
            {
                Courses = await _context.Course
                .ToListAsync(cancellationToken)
            };
        }
    }
}
