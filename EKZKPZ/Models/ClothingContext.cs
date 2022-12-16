using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKZKPZ.Models
{
    public class ClothingContext : DbContext
    {
        public ClothingContext(DbContextOptions<ClothingContext> options)
           : base(options)
        { }

        public DbSet<Clothing> Clothing { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clothing>().HasKey(c => c.Id);
            builder.Entity<Clothing>().Property(c => c.Name).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Brand).IsRequired();
            builder.Entity<Clothing>().Property(c => c.ProductionDate).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Size).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Model).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Quantity).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Price).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Discount).IsRequired();
            builder.Entity<Clothing>().Property(c => c.Discount).HasComputedColumnSql("DATEDIFF(MONTH, [ProductionDate], GETDATE()) * 5");

            builder.Entity<Clothing>().HasData(
                new Clothing
                {
                    Id = 1,
                    Name = "Sweetshot",
                    Brand = "Nike",
                    ProductionDate = new DateTime(2022, 10, 15),
                    Size = Size.M,
                    Model = "12afe321",
                    Quantity = 5,
                    Price = 100
                },
                new Clothing
                {
                    Id = 2,
                    Name = "Shoes",
                    Brand = "Adiddas",
                    ProductionDate = new DateTime(2022, 12, 15),
                    Size = Size.XS,
                    Model = "12asdfdf1",
                    Quantity = 10,
                    Price = 500
                },
                new Clothing
                {
                    Id = 3,
                    Name = "Cap",
                    Brand = "Puma",
                    ProductionDate = new DateTime(2022, 8, 15),
                    Size = Size.XL,
                    Model = "12adfer321",
                    Quantity = 3,
                    Price = 50
                }
                );
        }
     }
}
