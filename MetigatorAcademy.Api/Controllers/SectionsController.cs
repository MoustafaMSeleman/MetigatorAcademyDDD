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
        private readonly IRepository<Section> _sectionRepository;

        public SectionsController(IRepository<Section> sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        [HttpGet("AddRange")]
        public IActionResult AddRange(List<Section> list)
        {
            //return Ok( _sectionRepository.AddRange(SeedData.LoadCorporates()));
            return Ok(_sectionRepository.AddRange(list));
        }
        [HttpGet("Add")]
        public IActionResult Add(Section section) 
        {
            return Ok(_sectionRepository.Add(section));
        }
        [HttpGet("Update")]
        public IActionResult Update(Section section)
        {
            return Ok(_sectionRepository.Update(section));
        }
        [HttpGet("Remove")]
        public IActionResult Remove(Section section)
        {
            return Ok(_sectionRepository.Remove(section));
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            return Ok(_sectionRepository.GetById(id));
        }
        [HttpGet("GetByIdAsync")]
        public IActionResult GetByIdAsync(int id)
        {
            return Ok(_sectionRepository.GetByIdAsync(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_sectionRepository.GetAll());
        }
        [HttpGet("GetAllAsync")]
        public IActionResult GetAllAsync()
        {
            return Ok(_sectionRepository.GetAllAsync());
        }
        
    }
}
