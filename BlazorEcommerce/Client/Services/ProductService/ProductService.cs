using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        private readonly HttpClient _http;

        public event Action ProductsChanced;

        public ProductService(HttpClient http)
        {
            _http= http;
        }
        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?  
                await _http.GetFromJsonAsync < ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync < ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}")
                ;

             if(result != null && result.Data !=null) 
                Products = result.Data;

            ProductsChanced.Invoke();
        }

        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");

            return result;
        }

    }
}