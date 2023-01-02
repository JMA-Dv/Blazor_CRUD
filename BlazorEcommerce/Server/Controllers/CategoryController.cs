using BlazorEcommerce.Server.Services.CategoryService;
using BlazorEcommerce.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _category;

        public CategoryController(ICategoryService category)
        {
            _category = category;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories() { 
            var result = await _category.GetCategoriesAsync();
            return Ok(result);  
        }

        
        
    }
}
