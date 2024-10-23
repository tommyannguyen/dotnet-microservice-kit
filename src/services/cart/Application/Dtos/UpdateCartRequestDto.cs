using DotMK.Cart.Domain;

namespace DotMK.Cart.Application.Dtos;
public class UpdateCartRequestDto
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();
}
