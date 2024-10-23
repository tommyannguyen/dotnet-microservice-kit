using DotMK.Catalog.Application;
using DotMK.Catalog.Application.Products;
using DotMK.Catalog.Infrastructure.Repositories;
using DotMK.Framework.Core.Events;
using DotMK.Framework.Infrastructure;
using DotMK.Framework.Infrastructure.Auth.OpenId;
using DotMK.Framework.Infrastructure.Messaging;
using DotMK.Framework.Persistence.Mongo;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DotMK.Catalog.Infrastructure;
public static class Extensions
{
    public static void AddCatalogInfrastructure(this WebApplicationBuilder builder)
    {
        var applicationAssembly = typeof(CatalogApplication).Assembly;
        var policyNames = new List<string> { "catalog:read", "catalog:write" };
        builder.Services.AddOpenIdAuth(builder.Configuration, policyNames);
        builder.Services.AddMassTransit(config =>
        {
            config.AddConsumers(applicationAssembly);
            config.UsingRabbitMq((ctx, cfg) =>
            {
                cfg.Host(builder.Configuration["RabbitMqOptions:Host"]);
                cfg.ConfigureEndpoints(ctx, new KebabCaseEndpointNameFormatter("catalog", false));
            });
        });
        builder.AddInfrastructure(applicationAssembly);
        builder.Services.AddTransient<IEventPublisher, EventPublisher>();
        builder.Services.AddMongoDbContext<MongoDbContext>(builder.Configuration);
        builder.Services.AddTransient<IProductRepository, ProductRepository>();
    }
    public static void UseCatalogInfrastructure(this WebApplication app)
    {
        app.UseInfrastructure(app.Environment);
    }
}
