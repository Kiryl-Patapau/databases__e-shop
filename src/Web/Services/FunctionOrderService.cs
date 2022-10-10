using Ardalis.GuardClauses;
using BlazorShared.Models;
using Microsoft.eShopWeb.Web.Interfaces;
using Microsoft.Extensions.Options;

namespace Microsoft.eShopWeb.Web.Services;

public class FunctionOrderService : IFunctionOrderService
{
    private readonly HttpClient _httpClient;
    private readonly OrderServiceConfiguration _configuration;

    public FunctionOrderService(HttpClient httpClient, IOptions<OrderServiceConfiguration> configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration.Value;
    }

    public async Task Save(OrderDto order)
    {
        Guard.Against.Null(order, nameof(order));

        using var request = new HttpRequestMessage(HttpMethod.Post, _configuration.SaveUri);
        request.Headers.Add(OrderServiceConfiguration.KeyHeader, _configuration.Key);
        request.Content = JsonContent.Create(order);
        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
    }
}
