using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly IRepository<Office> _officeRepository;

        public OfficesController(IRepository<Office> officeRepository)
        {
            _officeRepository = officeRepository;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange()
        {
            return Ok(_officeRepository.AddRange(SeedData.LoadOffices()));
        }
    }
}
