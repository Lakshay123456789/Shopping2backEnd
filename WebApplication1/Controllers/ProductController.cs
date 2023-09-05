using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartBLL.AccountServices;
using ShoppingCartBLL.PostService;
using ShoppingCartBLL.ProductServices;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.EntityModels.ModelDto;
using ShoppingCartModels.ModelDto;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   [Authorize(Roles ="Admin")]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IPostService _postService;
        public ProductController(IProductService productService,IPostService postService)
        {
            _productService = productService;
            _postService = postService;
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

        [HttpPost("addNewPost")]

        public async Task<IActionResult> InsertNewPost(PostDto post)
        {
            try
            {
                await _postService.InsertPost(post);
                return Ok();
            }catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetAllImage")]
      
        public async Task<IActionResult> GetAllMethod()
        {
            try
            {
                var posts = await _postService.GetAllMethod();
                return Ok(posts);

            }catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
