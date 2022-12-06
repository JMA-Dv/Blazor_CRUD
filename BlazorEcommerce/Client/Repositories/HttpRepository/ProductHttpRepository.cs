using BlazorEcommerce.Shared;
using System.Text.Json;

namespace BlazorEcommerce.Client.Repositories.HttpRepository
{
    public class ProductHttpRepository : IProductHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ProductHttpRepository(HttpClient client, JsonSerializerOptions options)
        {
            _client = client;
            _options = options;
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = await _client.GetAsync("api/product");
            var content  = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var products = JsonSerializer.Deserialize<List<Product>>(content,_options);
            return products;
        }
    }
}
