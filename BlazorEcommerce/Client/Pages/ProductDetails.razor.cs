using Microsoft.AspNetCore.Components;

namespace BlazorEcommerce.Client.Pages
{
    public partial class ProductDetails
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Parameter]
        public int Id { get; set; }



        private Product? product = null;
        private string message = string.Empty;

        protected override async Task OnParametersSetAsync()
        {
            message = "loading project";
            var result = await ProductService.GetProductById(Id); 
            if (!result.Success)
            {
                message = result.Message;
            }
            else
            {
                product = result.Data;
            }
        }
    }
}
