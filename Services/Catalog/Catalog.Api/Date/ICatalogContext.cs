using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Date
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
