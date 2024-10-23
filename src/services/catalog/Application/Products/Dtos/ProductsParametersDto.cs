using DotMK.Framework.Core.Pagination;

namespace DotMK.Catalog.Application.Products.Dtos;
public class ProductsParametersDto : PaginationParameters
{
    public string? Keyword { get; set; }
}
