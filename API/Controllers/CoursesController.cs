using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CoursesController : BaseController
    {
        private readonly IGenericRepository<Course> _repository;
        private readonly IMapper _mapper;

        public CoursesController(IGenericRepository<Course> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;

        }

        [HttpGet]

        public async Task<ActionResult<IReadOnlyList<CourseDto>>> GetCourses()
        {
            var courses = await _repository.ListAllAsync();
            return Ok(_mapper.Map<IReadOnlyList<Course>, IReadOnlyList<CourseDto>>(courses));
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CourseDto>> GetCourse(Guid id)
        {
            var course = await _repository.GetByIdAsync(id);

            return _mapper.Map<Course, CourseDto>(course);
        }
    }
}