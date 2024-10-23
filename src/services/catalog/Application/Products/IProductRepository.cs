using DotMK.Catalog.Application.Products.Dtos;
using DotMK.Catalog.Domain.Products;
using DotMK.Framework.Core.Database;
using DotMK.Framework.Core.Pagination;

namespace DotMK.Catalog.Application.Products;
public interface IProductRepository : IRepository<Product, Guid>
{
    Task<PagedList<ProductDto>> GetPagedProductsAsync<ProductDto>(ProductsParametersDto parameters, CancellationToken cancellationToken = default);
}