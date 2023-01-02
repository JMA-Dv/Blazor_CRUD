using BlazorEcommerce.Shared.Responses;

namespace BlazorEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductByIdAsync(int Id);
        Task<ServiceResponse<List<Product>>> GetProductCategoryAsync(string categoryUrl);
    }
}
