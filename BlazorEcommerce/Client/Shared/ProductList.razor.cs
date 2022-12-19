using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        public HttpClient Http { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }
    }
}
