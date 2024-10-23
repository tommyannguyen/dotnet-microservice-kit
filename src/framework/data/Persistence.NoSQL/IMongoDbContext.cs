using MongoDB.Driver;

namespace DotMK.Framework.Persistence.Mongo;
public interface IMongoDbContext : IDisposable
{
    IMongoCollection<T> GetCollection<T>(string? name = null);
}