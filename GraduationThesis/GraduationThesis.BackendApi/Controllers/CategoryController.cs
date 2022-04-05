using GraduationThesis.Application.Interfaces;
using GraduationThesis.Utilities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace GraduationThesis.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

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
            var productVm = _categoryService.Add(categoryViewModel);
            _categoryService.Save();
            return new OkObjectResult(productVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            else
            {
                _categoryService.Update(categoryViewModel);
                _categoryService.Save();
            }
            return new OkObjectResult(categoryViewModel);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            else
            {
                _categoryService.Delete(id);
                _categoryService.Save();
                return new OkObjectResult(id);
            }
        }


    }
}
