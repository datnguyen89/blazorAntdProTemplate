using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using blazorAntdProTemplate.Models;

namespace blazorAntdProTemplate.Services
{
    public interface IProductService
    {
        Task<ProductList> GetCurrentProductAsync();
    }

    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductList> GetCurrentProductAsync()
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer abvdef");

            var data = await _httpClient.GetFromJsonAsync<ProductList>("https://reqres.in/api/users?page=2");
            return data;
        }
    }
}