using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoporatesController : ControllerBase
    {
        private readonly IRepository<Coporate> _coporateRepository;

        public CoporatesController(IRepository<Coporate> coporateRepository)
        {
            _coporateRepository = coporateRepository;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange()
        {
            return Ok(_coporateRepository.AddRange(SeedData.LoadCorporates()));
        }
    }
}
