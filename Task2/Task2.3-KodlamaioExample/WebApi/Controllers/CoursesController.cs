using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseService.GetAll();
            var courseGetDtos = _mapper.Map<List<CourseGetDto>>(result.Data);

            if (result.Success)
            {
                return Ok(courseGetDtos);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _courseService.Get(id);
            var courseGetDto = _mapper.Map<CourseGetDto>(result.Data);

            if (result.Success)
            {
                return Ok(courseGetDto);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(CourseAddDto courseAddDto)
        {
            var course = _mapper.Map<Course>(courseAddDto);
            var result = _courseService.Add(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(CourseUpdateDto courseUpdateDto)
        {
            var course = _mapper.Map<Course>(courseUpdateDto);
            var result = _courseService.Update(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var course = _courseService.Get(id).Data;
            var result = _courseService.Delete(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
