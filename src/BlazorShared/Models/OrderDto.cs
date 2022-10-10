using System.Collections.Generic;

namespace BlazorShared.Models;

public class OrderDto
{
    public string ShippingAddress { get; set; }

    public IEnumerable<OrderItemDto> Items { get; set; }

    public decimal FinalPrice { get; set; }
}
