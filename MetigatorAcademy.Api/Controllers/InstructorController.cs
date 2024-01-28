using MetigatorAcademy.Domain.Common;
using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetigatorAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IRepository<Instructor> _instructorRepository;

        public InstructorController(IRepository<Instructor> instructorRepository) 
        { 
            _instructorRepository = instructorRepository;
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
           return Ok( _instructorRepository.GetById(id));
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id) 
        {
            return Ok(await _instructorRepository.GetByIdAsync(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            return Ok( _instructorRepository.GetAll());
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName(string name) 
        {
            return Ok(_instructorRepository.Find(i => i.FName   == name || i.LName ==name));
        }

        [HttpGet("FindAll")]
        public IActionResult FindAllWithName(string name)
        {
            return Ok(_instructorRepository.FindAll(i => i.FName == name || i.LName == name));
        }

        [HttpGet("GetAllOrdered")]
        public IActionResult FindAll(string name)
        {
            return Ok(_instructorRepository.FindAll(i => i.FName == name || i.LName == name,b => b.Id,OrderBy.Descending));
        }

        [HttpGet("AddInstructor")]
        public IActionResult Add(Instructor instructor)
        {
            return Ok(_instructorRepository.Add(instructor));
        }
        [HttpGet("AddRange")]
        public IActionResult AddRange() 
        {
            var list = SeedData.LoadInstructors();
            foreach (var item in list) { 
                if(item == null)
                    Console.WriteLine("NULL");
                else
                Console.WriteLine(item); }
            return Ok(_instructorRepository.AddRange(list));
        }
    }
}
