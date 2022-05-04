using Microsoft.AspNetCore.Mvc;
using ASP.NET_CORE_6_REST_API_Shop_Example.Interfaces;
using ASP.NET_CORE_6_REST_API_Shop_Example.Models;

namespace ASP.NET_CORE_6_REST_API_Shop_Example.Controllers
{
    [Route("/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //GET All Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopProduct>>> ProductList()
        {
            return await _productService.SelectAll<ShopProduct>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShopProduct>> GetProduct(Guid id)
        {
            var model = await _productService.SelectById<ShopProduct>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(Guid id, ShopProduct model)
        {
            if (model is null)
            {
                return BadRequest();
            }
             
            if (await _productService.SelectById<ShopProduct>(id) is null)
            {
                return NotFound();
            } 

            await _productService.UpdateAsync<ShopProduct>(model);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<ShopProduct>> InsertProduct([FromBody] ShopProduct model)
        {
            if (model is null)
            {
                return BadRequest();
            }
            await _productService.CreateAsync<ShopProduct>(model);
            return CreatedAtAction("GetProduct", new { id = model.Id }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ShopProduct>> DeleteProduct(Guid id)
        {
            var DBmodel = await _productService.SelectById<ShopProduct>(id);

            if (DBmodel == null)
            {
                return NotFound();
            }

            await _productService.DeleteAsync<ShopProduct>(DBmodel);

            return NoContent();
        }
    }
}