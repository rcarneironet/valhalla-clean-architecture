using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Valhalla.Application.UseCases.Courses.Queries.ViewAllCourses;

namespace Valhalla.Web.Controllers
{
    public class InitializeController : BaseController
    {
        [HttpGet("Course")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CourseListViewModel>> Initialize()
        {
            return Ok(await Mediator.Send(new ViewAllCoursesQuery()));
        }
    }
}
