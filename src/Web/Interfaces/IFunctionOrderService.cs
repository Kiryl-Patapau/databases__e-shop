using BlazorShared.Models;

namespace Microsoft.eShopWeb.Web.Interfaces;

public interface IFunctionOrderService
{
    Task Save(OrderDto order);
}
