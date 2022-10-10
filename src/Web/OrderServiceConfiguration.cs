namespace Microsoft.eShopWeb.Web;

public class OrderServiceConfiguration
{
    public const string ConfigPath = "OrderService";
    public const string KeyHeader = "x-functions-key";

    public string? Url { get; set; }

    public string? Key { get; set; }

    public string SaveUri => Url?.TrimEnd('/') + "/api/save";
}
