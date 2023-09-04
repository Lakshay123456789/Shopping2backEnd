using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartBLL.AccountServices;
using ShoppingCartBLL.ProductServices;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.ModelDto;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   [Authorize(Roles ="Admin")]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Getallproducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var result = await _productService.GetAllMethod();
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound("No products found.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            try
            {
                var result = await _productService.GetByIdMethod(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"Product with ID {id} not found.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("AddNewProduct")]
        public async Task<IActionResult> InsertProduct(ProductDto obj)
        {
            try
            {
                await _productService.InsertMethod(obj); // implemented in Service
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(Guid Id, ProductDto obj)
        {
            try
            {
                await _productService.UpdateMethod(obj, Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(Guid Id)
        {
            try
            {
                await _productService.DeleteMethod(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}
