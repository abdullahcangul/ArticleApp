using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleApp.Api.CustomFilters;
using ArticleApp.Business.Abstract;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.DTO.DTOs.Article;
using ArticleApp.DTO.DTOs.Category;
using ArticleApp.DTO.DTOs.CategoryArticle;
using ArticleApp.DTO.DTOs.Comment;
using ArticleApp.Entity.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArticleApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {

        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;
        private readonly IMemoryCache _memoryCache;


        public ArticlesController(IArticleService articleService, ICommentService commentService, IMapper mapper, IMemoryCache memoryCache)
        {
            _articleService = articleService;
            _commentService = commentService;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        [HttpGet()]
        public IActionResult Get() 
        {
           
            var result = _articleService.GetAllSortedByLastEditDate();
            if (result.Succes)
            {
                if (_memoryCache.TryGetValue("artictleList",out List<ArticleDto> list))
                {
                    return Ok(list);
                }
                var articleList = _mapper.Map<List<ArticleDto>>(result.Data);

                _memoryCache.Set("artictleList", articleList, new MemoryCacheEntryOptions()
                {
                    AbsoluteExpiration = DateTime.Now.AddDays(1),
                    Priority=CacheItemPriority.Normal
                });
                return Ok(articleList);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Category>))]
        public IActionResult GetCategoriesByArticleId(int id)
        {
            var result = _articleService.GetCategoriesByArticleId(id);
            if (result.Succes)
            {
                return Ok(_mapper.Map<List<CategoryListDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Comment>))]
        public IActionResult GetCommentsByArticleId(int id)
        {
            var result = _articleService.GetCommentsByArticleId(id);
            if (result.Succes)
            {
                return Ok(_mapper.Map<List<CommentListDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Comment>))]
        public IActionResult GetAllByCategory(int id)
        {
            var result = _articleService.GetAllByCategory(id);
            if (result.Succes)
            {
                return Ok(_mapper.Map<List<ArticleDto>>( result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Article>))]
        public IActionResult GetById(int id)
        {
            var result = _articleService.GetById(id);
            if (result.Succes)
            {
                return Ok(_mapper.Map<ArticleDto>(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpPost]
        [ValidModel]
        public IActionResult Create([FromForm]ArticleAddDto articleDto)
        {
            var article = _mapper.Map<Article>(articleDto);
            article.PublishedDate = DateTime.Now;
            article.LastEditDate = DateTime.Now;
            article.Uid = Guid.NewGuid().ToString();

            var result = _articleService.Add(article);
            if (result.Succes)
            {
                return Created("",_mapper.Map<ArticleDto>(result.Data));
            }
            return BadRequest(result.Message);

        }

        [HttpPut("{id}")]
        [ValidModel]
        public IActionResult Update(int id,[FromForm]ArticleUpdateDto articleDto)
        {
            if (id != articleDto.Id)
                return BadRequest("geçersiz id");

            var article = _mapper.Map<Article>(articleDto);
            article.LastEditDate = DateTime.Now;

            var result = _articleService.Update(article);
            if (result.Succes)
            {
                return Ok(_mapper.Map<ArticleDto>(result.Data));
            }
            return BadRequest(result.Message);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var resul = _articleService.GetById(id);
            if (resul.Succes)
            {
                _articleService.Delete(resul.Data);
                return NoContent();
            }
            return BadRequest();
        }

        [HttpGet("[action]")]
        public  IActionResult Search([FromQuery] string s)
        {
            var result = _articleService.Search(s);
            if (result.Succes)
            {
                return Ok(_mapper.Map<List<ArticleDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        [ValidModel]
        public IActionResult AddComment([FromForm]CommentAddDto commentDto)
        {
            commentDto.CommentDate = DateTime.Now;
            _commentService.Add(_mapper.Map<Comment>(commentDto));
            return Created("", commentDto);
        }

        [HttpPost("[action]")]
        [ValidModel]
        public IActionResult AddToCategory(CategoryArticleDto categoryArticleDto)
        {
            _articleService.AddToCategory(categoryArticleDto);
            return Created("", categoryArticleDto);
        }

        [HttpDelete("[action]")]
        public  IActionResult RemoveFromCategory([FromQuery] CategoryArticleDto categoryArticleDto)
        {
            _articleService.RemoveFromCategory(categoryArticleDto);
            return NoContent();
        }
    }
}
