using GraduationThesis.Application.Implementation;
using GraduationThesis.Application.Interfaces;
using GraduationThesis.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationThesis.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        // GET: api/values
        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            _productService.Save();
            return new OkObjectResult(product);
        }
    }
}
