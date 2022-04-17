using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Model;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("/products")]
        public IActionResult GetProductList()
        {
            return Ok(ProductService.GetProductsFromDatabase());
        }

    }
}
