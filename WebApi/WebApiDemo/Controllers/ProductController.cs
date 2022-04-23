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
        [Route("products")]
        public IActionResult GetProductList()
        {
            ProductService productService = new ProductService();
            return Ok(productService.GetProductsFromDatabase());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductList(int id)
        {
            ProductService productService = new ProductService();
            return Ok(productService.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody]AddProductModel model)
        {
            ProductService productService = new ProductService();
            return Ok(productService.AddProduct(model));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateProductModel model)
        {
            ProductService productService = new ProductService();
            return Ok(productService.UpdateProduct(id, model));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            ProductService productService = new ProductService();
            return Ok(productService.DeleteProduct(id));
        }
    }
}
