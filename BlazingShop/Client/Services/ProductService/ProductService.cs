using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts() 
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's...",
                    Description = "The Hitchhiker's...Description",
                    Image = "http://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 ....Description",
                    Image = "http://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "The Hitchhiker's...",
                    Description = "The Hitchhiker's...Description",
                    Image = "http://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 ....Description",
                    Image = "http://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                }

            };
        }
    }
}
