using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses;

namespace Valhalla.Web.Controllers.UseCases.Courses
{
    public class InitializeController : BaseController
    {

        [HttpGet("EfCore")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CourseListViewModel>> InitializeEfCore()
        {
            return Ok(await Mediator.Send(new ViewAllCoursesQuery()));
        }

        [HttpGet("Dapper")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CourseListViewModel>> InitializeDapper()
        {
            return Ok(await Mediator.Send(new ViewAllCoursesDapperQuery()));
        }
    }
}
