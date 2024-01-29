﻿using MetigatorAcademy.Domain.Common.Interfaces;
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
            return Ok(_unitOfWork.sectionsRepository.GetAll());
        }
        [HttpGet("GetAllAsync")]
        public IActionResult GetAllAsync()
        {
            return Ok(_unitOfWork.sectionsRepository.GetAllAsync());
        }
        
    }
}
