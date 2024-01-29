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

        //private readonly IRepository<Schedule> _scheduleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public SchedulesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange() 
        {
            return Ok(_unitOfWork.schedulesRepository.AddRange(SeedData.LoadSchedules()));
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            return Ok(_unitOfWork.schedulesRepository.GetById(id));
        }
        [HttpPost("Add")]
        public IActionResult Add(Schedule schedule) 
        {
            _unitOfWork.schedulesRepository.Add(schedule);
            _unitOfWork.SaveChanges();
            return Ok(schedule);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            return Ok(_unitOfWork.schedulesRepository.GetAll());
        }
    }
}
