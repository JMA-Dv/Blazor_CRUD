using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private static List<Product> Products = new()
        {
            new Product{ Id = 1,
            Title = "How to Win Friends and Influence People ",
            ImageUrl="https://th.bing.com/th/id/OIP.pfsMDzqiopN7nHtG78hyzAHaLq?pid=ImgDet&rs=1",
            Description = " You can go after the job you want--and get it!\r\nYou can take the job you have--and improve it!\r\nYou can take any situation--and make it work for you! Dale Carnegie's rock-solid, time-tested advice has carried countless people up the ladder of success in their business and personal lives. One of the most groundbreaking and timeless bestsellers of all time, How to Win Friends & Influence People will teach you",
            Price = 265.18m
            },
            new Product{ Id = 2,
            Title = "The 48 Laws of Power ",
            ImageUrl="https://thepowermoves.com/wp-content/uploads/the-48-laws-of-power-list-712x1024.jpg",
            Description = "Amoral, cunning, ruthless, and instructive, this multi-million-copy New York Times bestseller is the definitive manual for anyone interested in gaining, observing, or defending against ultimate control – from the author of The Laws of Human Nature.",
            Price = 292.96m
            },
            new Product{ Id = 3,
            Title = "Atomic Habits",
            ImageUrl="https://th.bing.com/th/id/OIP.e6TtDwNcDhX79yDamKZq9wHaJa?pid=ImgDet&rs=1",
            Description = "No importa sus metas, Atomic Habits este libro en inglés ofrece un marco probado para mejorar... cada día. James Clear, uno de los principales expertos del mundo en formación de hábitos, revela estrategias prácticas que le enseñarán exactamente cómo formar buenos hábitos, romper los malos y dominar los pequeños comportamientos que conducen a resultados notables.",
            Price = 421.30m
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }

}
