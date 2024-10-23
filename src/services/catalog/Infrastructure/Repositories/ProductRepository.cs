using DotMK.Catalog.Application.Products;
using DotMK.Catalog.Application.Products.Dtos;
using DotMK.Catalog.Domain.Products;
using DotMK.Framework.Core.Pagination;
using DotMK.Framework.Core.Services;
using DotMK.Framework.Persistence.Mongo;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace DotMK.Catalog.Infrastructure.Repositories;

public class ProductRepository : MongoRepository<Product, Guid>, IProductRepository
{
    private readonly IMongoDbContext _dbContext;
    public ProductRepository(IMongoDbContext context, IDateTimeService dateTimeService) : base(context, dateTimeService)
    {
        _dbContext = context;
    }

    public async Task<PagedList<ProductDto>> GetPagedProductsAsync<ProductDto>(ProductsParametersDto parameters, CancellationToken cancellationToken = default)
    {
        var queryable = _dbContext.GetCollection<Product>().AsQueryable();
        if (!string.IsNullOrEmpty(parameters.Keyword))
        {
            string keyword = parameters.Keyword.ToLower();
            queryable = queryable.Where(t => t.Name.ToLower().Contains(keyword)
            || t.Details.ToLower().Contains(keyword)
            || t.Code.ToLower().Contains(keyword));
        }
        queryable = queryable.OrderBy(p => p.CreatedOn);
        return await queryable.ApplyPagingAsync<Product, ProductDto>(parameters.PageNumber, parameters.PageSize, cancellationToken);
    }
}
