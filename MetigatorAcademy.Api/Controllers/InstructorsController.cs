using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IRepository<Instructor> _instructorRepository;

        public InstructorsController(IRepository<Instructor> instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Instructor> list)
        {
            //return Ok(_instructorRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_instructorRepository.AddRange(list));
        }
    }
}
