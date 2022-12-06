using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Repositories.HttpRepository
{
    public interface IProductHttpRepository
    {
        Task<List<Product>> GetProducts();
    }


}
