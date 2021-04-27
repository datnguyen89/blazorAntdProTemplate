using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using blazorAntd.Models;

namespace blazorAntd.Services
{
    public interface IProductService
    {
        Task<ProductList> GetCurrentProductAsync(int page);
    }

    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductList> GetCurrentProductAsync(int page)
        {
            var data = await _httpClient.GetFromJsonAsync<ProductList>($"https://reqres.in/api/users?page={page}");
            return data;
        }
    }
}