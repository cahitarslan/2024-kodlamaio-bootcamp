using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;
        private readonly IMapper _mapper;

        public InstructorsController(IInstructorService instructorService, IMapper mapper)
        {
            _instructorService = instructorService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _instructorService.GetAll();
            var instructorGetDtos = _mapper.Map<List<InstructorGetDto>>(result.Data);

            if (result.Success)
            {
                return Ok(instructorGetDtos);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _instructorService.Get(id);
            var instructorGetDto = _mapper.Map<InstructorGetDto>(result.Data);

            if (result.Success)
            {
                return Ok(instructorGetDto);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(InstructorAddDto instructorAddDto)
        {
            var instructor = _mapper.Map<Instructor>(instructorAddDto);
            var result = _instructorService.Add(instructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(InstructorUpdateDto instructorUpdateDto)
        {
            var instructor = _mapper.Map<Instructor>(instructorUpdateDto);
            var result = _instructorService.Update(instructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var instructor = _instructorService.Get(id).Data;
            var result = _instructorService.Delete(instructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
