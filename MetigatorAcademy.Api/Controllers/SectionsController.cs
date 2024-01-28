using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionsController : ControllerBase
    {
        private readonly IRepository<Section> _sectionRepository;

        public SectionsController(IRepository<Section> sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        [HttpGet("AddRange")]
        public IActionResult AddRange()
        {
            return Ok(_sectionRepository.AddRange(SeedData.LoadSections()));
        }
    }
}
