using MetigatorAcademy.Application.DTOs;
using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using MetigatorAcademy.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoursesController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Course> list)
        {
            //return Ok(_courseRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_unitOfWork.coursesRepository.AddRange(list));
        }
        [HttpGet("GetAllInclude")]
        public IActionResult GetAll(string? included)
        {
            return Ok(_unitOfWork.coursesRepository.GetAll(included).
                Select(x =>
                new CourseDTO
                {
                    CourseName = x.CourseName,
                    Price = x.Price,
                    Sections = x.Sections.Select(z =>
                    new SectionDTO
                    {
                        SectionName = z.SectionName,
                        TimeSlot = z.TimeSlot
                    }).ToList(),
                })) 
                ;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var courses = _unitOfWork.coursesRepository.GetAll();
            var coursesDTO = courses.Select(x =>
                new CourseDTO
                {
                    CourseName = x.CourseName,
                    Price = x.Price,
                    Sections = x.Sections.Select(z =>
                    new SectionDTO
                    {
                        SectionName = z.SectionName,
                        TimeSlot = z.TimeSlot
                    }).ToList()
                }) ;
            return Ok(coursesDTO);
        }
    }
}
