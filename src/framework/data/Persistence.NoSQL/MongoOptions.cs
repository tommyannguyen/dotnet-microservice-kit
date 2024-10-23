using DotMK.Framework.Infrastructure.Options;

namespace DotMK.Framework.Persistence.Mongo;

public class MongoOptions : IOptionsRoot
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
}
