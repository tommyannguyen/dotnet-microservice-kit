using DotMK.Cart.Domain;

namespace DotMK.Cart.Application;
public interface ICartRepository
{
    Task<CustomerCart?> GetCustomerCartAsync(string customerId, CancellationToken cancellationToken);
    Task UpdateCustomerCartAsync(string customerId, CustomerCart cart, CancellationToken cancellationToken);
}
