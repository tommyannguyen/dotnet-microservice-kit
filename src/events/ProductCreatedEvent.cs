using DotMK.Framework.Core.Events;

namespace DotMK.Shared.Events;

public class ProductCreatedEvent : DomainEvent
{
    public Guid ProductId { get; }
    public string ProductName { get; }

    public ProductCreatedEvent(Guid productId, string productName)
    {
        ProductId = productId;
        ProductName = productName;
    }
}