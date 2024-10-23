using DotMK.Framework.Core.Exceptions;

namespace DotMK.Catalog.Application.Products.Exceptions;
internal class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(object productId) : base($"Product with ID '{productId}' is not found.")
    {
    }
}
