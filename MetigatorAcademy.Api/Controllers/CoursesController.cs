using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepository<Course> _courseRepository;

        public CoursesController(IRepository<Course> courseRepository) 
        {
            _courseRepository = courseRepository;
        }
        [HttpGet("AddRange")]
        public IActionResult AddRange()
        {
            return Ok(_courseRepository.AddRange(SeedData.LoadCourses()));
        }
    }
}
