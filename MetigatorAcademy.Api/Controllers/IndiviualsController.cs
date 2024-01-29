using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndiviualsController : ControllerBase
    {
        // private readonly IRepository<Indiviual> _indiviualRepository;
        private readonly IUnitOfWork _unitOfWork;
        public IndiviualsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Indiviual> list)
        {
            //return Ok(_indiviualRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_unitOfWork.indiviualsRepository.AddRange(list));
        }
    }
}
