using DotMK.Catalog.Application.Products.Dtos;
using DotMK.Catalog.Domain.Products;
using Mapster;

namespace DotMK.Catalog.Application.Products.Mappings;
public sealed class ProductMappings : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductDto>();
        config.NewConfig<Product, ProductDetailsDto>();
    }
}