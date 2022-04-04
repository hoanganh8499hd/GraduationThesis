using GraduationThesis.Application.Implementation;
using GraduationThesis.Application.Interfaces;
using GraduationThesis.Utilities.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace GraduationThesis.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllProduct()
        {
            return new OkObjectResult(_productService.GetAllProduct());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var model = _productService.GetProductById(id);
            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductViewModel productViewModel)
        {
            var productVm = _productService.Add(productViewModel);
            _productService.Save();
            return new OkObjectResult(productVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody] ProductViewModel productViewModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            else
            {
                _productService.Update(productViewModel);
                _productService.Save();
            }
            return new OkObjectResult(productViewModel);
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
                _productService.Delete(id);
                _productService.Save();
                return Ok();
            }
        }
    }
}
