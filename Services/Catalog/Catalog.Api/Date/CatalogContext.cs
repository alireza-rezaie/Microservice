using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Date
{
    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }

        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatebaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatebaseSettings:DatebaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatebaseSettings:CollectionName"));
            SeedData.SeedDataProdcts(Products);
        }
    }
}
