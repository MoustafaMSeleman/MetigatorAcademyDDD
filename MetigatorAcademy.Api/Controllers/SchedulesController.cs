using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        
        private readonly IRepository<Schedule> _scheduleRepository;

        public SchedulesController(IRepository<Schedule> scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange() 
        {
            return Ok(_scheduleRepository.AddRange(SeedData.LoadSchedules()));
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            return Ok(_scheduleRepository.GetById(id));
        }
    }
}
