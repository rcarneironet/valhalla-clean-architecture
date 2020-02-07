using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Valhalla.Application.Abstractions.EntityFramework;
using Valhalla.Domain.Courses;

namespace Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses
{
    public class ViewAllCoursesQueryHandler : IRequestHandler<ViewAllCoursesQuery, ViewAllCoursesViewModel>
    {
        private readonly IValhallaContext _context;
        private readonly IMapper _mapper;

        public ViewAllCoursesQueryHandler(
            IValhallaContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
