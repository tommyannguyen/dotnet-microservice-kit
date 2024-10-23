using DotMK.Framework.Core.Exceptions;

namespace DotMK.Cart.Application.Exceptions;
internal class CartNotFoundException : NotFoundException
{
    public CartNotFoundException(object customerId) : base($"Cart for Customer '{customerId}' is not found.")
    {
    }
}
