using System.Collections.Generic;
using ArticleApp.Api.CustomFilters;
using ArticleApp.Business.Abstract;
using ArticleApp.DAL.Abstract;
using ArticleApp.DTO.DTOs.Category;
using ArticleApp.Entity.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ArticleApp.Api.Controllers
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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<CategoryListDto>>(_categoryService.GetAllSortedById()));
        }
        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Category>))]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Succes)
            {
                return Ok(_mapper.Map<CategoryListDto>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpPost]
        [ValidModel]
        public IActionResult Create([FromForm] CategoryAddDto categoryAddDto)
        {
             _categoryService.Add(_mapper.Map<Category>(categoryAddDto));
            return Created("", categoryAddDto);
        }
        [HttpPut("{id}")]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Category>))]
        public IActionResult Update(int id, [FromForm] CategoryUpdateDto categoryUpdateDto)
        {
            if (id != categoryUpdateDto.Id)
                return BadRequest("geçersiz id");
             _categoryService.Update(_mapper.Map<Category>(categoryUpdateDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidId<Category>))]
        public IActionResult Delete(int id)
        {
            var result=_categoryService.DeleteCorrect(id);
            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message); 
        }
    }
}
