using MetigatorAcademy.Application.DTOs;
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
        //private readonly IRepository<Section> _sectionRepository;
        private readonly IUnitOfWork _unitOfWork;
        public SectionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Section> list)
        {
            //return Ok( _sectionRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_unitOfWork.sectionsRepository.AddRange(list));
        }
        [HttpGet("Add")]
        public IActionResult Add(Section section) 
        {
            return Ok(_unitOfWork.sectionsRepository.Add(section));
        }
        [HttpGet("Update")]
        public IActionResult Update(Section section)
        {
            return Ok(_unitOfWork.sectionsRepository.Update(section));
        }
        [HttpGet("Remove")]
        public IActionResult Remove(Section section)
        {
            return Ok(_unitOfWork.sectionsRepository.Remove(section));
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            return Ok(_unitOfWork.sectionsRepository.GetById(id));
        }
        [HttpGet("GetByIdAsync")]
        public IActionResult GetByIdAsync(int id)
        {
            return Ok(_unitOfWork.sectionsRepository.GetByIdAsync(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var sections = _unitOfWork.sectionsRepository.GetAll();
            var result = sections.Select(x => new SectionDTO
            {
                SectionName = x.SectionName,
                TimeSlot = x.TimeSlot,
                Instructor = new InstructorDTO
                {
                    FName = x.Instructor.FName,
                    LName = x.Instructor.LName
                },
                Course = new CourseDTO
                {
                    CourseName = x.Course.CourseName,
                    Price = x.Course.Price,


                },
                Schedule = new ScheduleDTO
                {
                    Title = x.Schedule.Title.ToString(),
                    SUN = x.Schedule.SUN,
                    MON = x.Schedule.MON,
                    TUE = x.Schedule.TUE,
                    WED = x.Schedule.WED,
                    THU = x.Schedule.THU,
                    FRI = x.Schedule.FRI,
                    SAT = x.Schedule.SAT,


                },
                Participants = x.Participants.Select(e =>
                    new ParticipantDTO
                    {
                        FName = e.FName,
                        LName = e.LName
                    }
                ).ToList()
            });
            return Ok(result);
        }
        [HttpGet("GetAllInclude")]
        public IActionResult GetAll(string? included)
        {
            
            return Ok(_unitOfWork.sectionsRepository.GetAll(included));

        }
        [HttpGet("GetAllAsync")]
        public IActionResult GetAllAsync()
        {
            return Ok(_unitOfWork.sectionsRepository.GetAllAsync());
        }
        
    }
}
