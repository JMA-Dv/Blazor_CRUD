using Microsoft.AspNetCore.Components;


namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList:IDisposable
    {
        [Inject]
        public HttpClient Http { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        public void Dispose()
        {
            ProductService.ProductsChanced -= StateHasChanged;
        }

        protected override void OnInitialized()
        {
            ProductService.ProductsChanced += StateHasChanged;
        }
    }
}
