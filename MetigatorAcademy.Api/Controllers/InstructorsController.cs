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
    public class InstructorsController : ControllerBase
    {
        //private readonly IRepository<Instructor> _instructorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public InstructorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Instructor> list)
        {
            //return Ok(_instructorRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_unitOfWork.instructorsRepository.AddRange(list));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            var instructors = _unitOfWork.instructorsRepository.GetAll();
            var result = instructors.Select(x =>
               new InstructorDTO
               {
                   FName = x.FName,
                   LName = x.LName,
                   Office = new OfficeDTO { 
                       OfficeName = x.Office.OfficeName,
                       OfficeLocation = x.Office.OfficeLocation
                   },
                   Sections = x.Sections.Select(z =>
                     new SectionDTO
                     {
                         SectionName = z.SectionName,
                         TimeSlot = z.TimeSlot,
                         Course = new CourseDTO
                         {
                             CourseName = z.Course.CourseName,
                             Price = z.Course.Price,
                         },

                     }
                   ).ToList()
               }
            );
            return Ok(result);
        }
        [HttpGet("GetAllInclude")]
        public IActionResult GetAll(string? included)
        {
            var instructors = _unitOfWork.instructorsRepository.GetAll(included);
            var result = instructors.Select(x =>
               new InstructorDTO
               {
                   FName = x.FName,
                   LName = x.LName,
                   Office = new OfficeDTO { },
                   Sections = x.Sections.Select( z => 
                     new SectionDTO { 
                         SectionName = z.SectionName,
                         TimeSlot = z.TimeSlot,
                         Course= new CourseDTO { 
                             CourseName=z.Course.CourseName,
                             Price = z.Course.Price,
                         },
                         
                     }
                   ).ToList()
               }
            );
            return Ok(result);
        }
        [HttpGet("Add")]
        public IActionResult Add()
        {
            var instructor = new Instructor(6,"Moustafa","Soliman",6);
            _unitOfWork.instructorsRepository.Add(instructor);
            _unitOfWork.SaveChanges();
            return Ok(instructor);
        }

    }
}
