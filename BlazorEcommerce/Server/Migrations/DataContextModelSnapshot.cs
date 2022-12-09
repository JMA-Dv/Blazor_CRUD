﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = " You can go after the job you want--and get it!\r\nYou can take the job you have--and improve it!\r\nYou can take any situation--and make it work for you! Dale Carnegie's rock-solid, time-tested advice has carried countless people up the ladder of success in their business and personal lives. One of the most groundbreaking and timeless bestsellers of all time, How to Win Friends & Influence People will teach you",
                            ImageUrl = "https://th.bing.com/th/id/OIP.pfsMDzqiopN7nHtG78hyzAHaLq?pid=ImgDet&rs=1",
                            Price = 265.18m,
                            Title = "How to Win Friends and Influence People "
                        },
                        new
                        {
                            Id = 2,
                            Description = "Amoral, cunning, ruthless, and instructive, this multi-million-copy New York Times bestseller is the definitive manual for anyone interested in gaining, observing, or defending against ultimate control – from the author of The Laws of Human Nature.",
                            ImageUrl = "https://thepowermoves.com/wp-content/uploads/the-48-laws-of-power-list-712x1024.jpg",
                            Price = 292.96m,
                            Title = "The 48 Laws of Power "
                        },
                        new
                        {
                            Id = 3,
                            Description = "No importa sus metas, Atomic Habits este libro en inglés ofrece un marco probado para mejorar... cada día. James Clear, uno de los principales expertos del mundo en formación de hábitos, revela estrategias prácticas que le enseñarán exactamente cómo formar buenos hábitos, romper los malos y dominar los pequeños comportamientos que conducen a resultados notables.",
                            ImageUrl = "https://th.bing.com/th/id/OIP.e6TtDwNcDhX79yDamKZq9wHaJa?pid=ImgDet&rs=1",
                            Price = 421.30m,
                            Title = "Atomic Habits"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
