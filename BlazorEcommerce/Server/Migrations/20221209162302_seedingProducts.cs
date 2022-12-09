using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class seedingProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, " You can go after the job you want--and get it!\r\nYou can take the job you have--and improve it!\r\nYou can take any situation--and make it work for you! Dale Carnegie's rock-solid, time-tested advice has carried countless people up the ladder of success in their business and personal lives. One of the most groundbreaking and timeless bestsellers of all time, How to Win Friends & Influence People will teach you", "https://th.bing.com/th/id/OIP.pfsMDzqiopN7nHtG78hyzAHaLq?pid=ImgDet&rs=1", 265.18m, "How to Win Friends and Influence People " });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Amoral, cunning, ruthless, and instructive, this multi-million-copy New York Times bestseller is the definitive manual for anyone interested in gaining, observing, or defending against ultimate control – from the author of The Laws of Human Nature.", "https://thepowermoves.com/wp-content/uploads/the-48-laws-of-power-list-712x1024.jpg", 292.96m, "The 48 Laws of Power " });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "No importa sus metas, Atomic Habits este libro en inglés ofrece un marco probado para mejorar... cada día. James Clear, uno de los principales expertos del mundo en formación de hábitos, revela estrategias prácticas que le enseñarán exactamente cómo formar buenos hábitos, romper los malos y dominar los pequeños comportamientos que conducen a resultados notables.", "https://th.bing.com/th/id/OIP.e6TtDwNcDhX79yDamKZq9wHaJa?pid=ImgDet&rs=1", 421.30m, "Atomic Habits" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
