using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorEcommerce.Server.Data.Config
{
    public class CategoryConfig
    {
        public CategoryConfig(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Book",
                    Url = "book"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "Video"
                });
        }
    }
}
