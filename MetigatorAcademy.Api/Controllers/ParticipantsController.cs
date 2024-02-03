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
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var participants = _unitOfWork.participantsRepository.GetAll();
            var result = participants.Select(x =>
              new ParticipantDTO { 
                FName = x.FName,
                LName = x.LName,
                Sections = x.Sections.Select( z =>
                  new SectionDTO { 
                    SectionName = z.SectionName,
                    TimeSlot = z.TimeSlot,
                    Course =  new CourseDTO { 
                        CourseName = z.Course.CourseName,
                        Price = z.Course.Price
                    },
                    Instructor = new InstructorDTO {
                        FName = z.Instructor.FName,
                        LName= z.Instructor.LName,
                    },
                    Schedule = new ScheduleDTO { 
                       Title = z.Schedule.Title.ToString(),
                        SUN = z.Schedule.SUN,
                        MON = z.Schedule.MON,
                        TUE = z.Schedule.TUE,
                        WED = z.Schedule.WED,
                        THU = z.Schedule.THU,
                        FRI = z.Schedule.FRI,
                        SAT = z.Schedule.SAT,

                    }
                  }
                ).ToList(),
                
                
              }
            );
            return Ok(result);
        }


    }
}
