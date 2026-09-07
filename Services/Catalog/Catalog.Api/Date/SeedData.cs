using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Date
{
    public class SeedData
    {
        public static void SeedDataProdcts(IMongoCollection<Product> productCollection)
        {
            bool existsProduct = productCollection.Find(p=> true).Any();
            if (!existsProduct)
            {
                productCollection.InsertManyAsync(GetSeedData());
            }
        }

        private static IEnumerable<Product> GetSeedData()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "iPhone 15",
                    Category = "Mobile",
                    Summary = "Apple iPhone 15",
                    Description = "Apple iPhone 15 with 128GB storage",
                    ImageFile = "product-1.png",
                    Price = 799.99m
                },

                new Product()
                {
                    Name = "Samsung Galaxy S24",
                    Category = "Mobile",
                    Summary = "Samsung Galaxy S24",
                    Description = "Samsung Galaxy S24 with 256GB storage",
                    ImageFile = "product-2.png",
                    Price = 899.99m
                }
            };
        }
    }
}
