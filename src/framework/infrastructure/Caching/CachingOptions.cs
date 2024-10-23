using DotMK.Framework.Infrastructure.Options;

namespace DotMK.Framework.Infrastructure.Caching;
public class CachingOptions : IOptionsRoot
{
    public bool EnableDistributedCaching { get; set; } = false;
    public int SlidingExpirationInMinutes { get; set; } = 2;
    public int AbsoluteExpirationInMinutes { get; set; } = 5;
    public bool PreferRedis { get; set; } = false;
    public string? RedisURL { get; set; }
}
