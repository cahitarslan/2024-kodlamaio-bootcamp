using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            var categoryGetDtos = _mapper.Map<List<CategoryGetDto>>(result.Data);

            if (result.Success)
            {
                return Ok(categoryGetDtos);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _categoryService.Get(id);
            var categoryGetDto =_mapper.Map<CategoryGetDto>(result.Data);

            if (result.Success)
            {
                return Ok(categoryGetDto);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(CategoryAddDto categoryAddDto)
        {
            var category = _mapper.Map<Category>(categoryAddDto);
            var result = _categoryService.Add(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            var category = _mapper.Map<Category>(categoryUpdateDto);
            var result = _categoryService.Update(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.Get(id).Data;
            var result = _categoryService.Delete(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
