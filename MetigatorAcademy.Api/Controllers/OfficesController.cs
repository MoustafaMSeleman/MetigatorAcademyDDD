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
    public class OfficesController : ControllerBase
    {
        // private readonly IRepository<Office> _officeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public OfficesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Office> list)
        {
            //return Ok( _officeRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_unitOfWork.officesRepository.AddRange(list));
        }
        [HttpGet("Add")]
        public IActionResult Add()
        {
            var office = new Office(6,"SpecialOffice","BuildingC");
            _unitOfWork.officesRepository.Add(office);
            return Ok(office);
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var offices = _unitOfWork.officesRepository.GetAll();
            var result = offices.Select(x => 
                  new OfficeDTO {
                      OfficeName = x.OfficeName,
                      OfficeLocation = x.OfficeLocation,
                      Instructor = new InstructorDTO { 
                         FName = x.Instructor.FName,
                         LName = x.Instructor.LName,
                      }
                  }
                );
            return Ok(result);
        }
    }
}
