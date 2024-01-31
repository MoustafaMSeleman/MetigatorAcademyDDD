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
        //private readonly IRepository<Coporate> _coporateRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CoporatesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Coporate> list)
        {
            //return Ok(_coporateRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_unitOfWork.coporatesRepository.AddRange(list));
        }
        [HttpGet("GetAllInclude")]
        public IActionResult GetAll(string? included)
        {
            return Ok(_unitOfWork.coporatesRepository.GetAll(included));
        }
    }
}
