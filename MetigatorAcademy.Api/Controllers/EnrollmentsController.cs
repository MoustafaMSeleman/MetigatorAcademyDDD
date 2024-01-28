using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IRepository<Enrollment> _enrollmentsRepository;

        public EnrollmentsController(IRepository<Enrollment> enrollmentsRepository)
        {
            _enrollmentsRepository = enrollmentsRepository;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange()
        {
            return Ok(_enrollmentsRepository.AddRange(SeedData.LoadEnrollments()));
        }
    }
}
