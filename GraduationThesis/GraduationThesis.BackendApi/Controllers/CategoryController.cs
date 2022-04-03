using GraduationThesis.Application.Interfaces;
using GraduationThesis.Utilities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GraduationThesis.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllCategory()
        {
            return new OkObjectResult(_categoryService.GetAllCategory());
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var model = _categoryService.GetCategoryById(id);
            return new OkObjectResult(model);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] CategoryViewModel categoryViewModel)
        {
            var productVm =  _categoryService.Add(categoryViewModel);
            _categoryService.Save();
            return new OkObjectResult(productVm);
        }
    }
}
