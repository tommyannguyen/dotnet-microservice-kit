using DotMK.Framework.Core.Caching;
using DotMK.Framework.Infrastructure.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotMK.Framework.Infrastructure.Caching;
public static class Extensions
{
    public static IServiceCollection AddCachingService(this IServiceCollection services, IConfiguration configuration)
    {
        var cacheOptions = services.BindValidateReturn<CachingOptions>(configuration);
        if (cacheOptions.EnableDistributedCaching)
        {
            if (cacheOptions.PreferRedis)
            {
                services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = cacheOptions.RedisURL;
                    options.ConfigurationOptions = new StackExchange.Redis.ConfigurationOptions()
                    {
                        AbortOnConnectFail = true,
                        EndPoints = { cacheOptions.RedisURL }
                    };
                });
            }
            else
            {
                services.AddDistributedMemoryCache();
            }

            services.AddTransient<ICacheService, DistributedCacheService>();
        }
        else
        {
            services.AddTransient<ICacheService, InMemoryCacheService>();
        }
        services.AddMemoryCache();

        return services;
    }
}
