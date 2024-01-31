using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
       // private readonly IRepository<Participant> _participantRepository;
       private readonly IUnitOfWork _unitOfWork;
        public ParticipantsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("GetAllInclude")]
        public IActionResult GetAll(string? included)
        {
            return Ok(_unitOfWork.participantsRepository.GetAll(included));
        }

    }
}
