using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using blazorAntdProTemplate.Models;

namespace blazorAntdProTemplate.Services
{
    public interface IResponseUsersService
    {
        Task<ResponseUsers> GetListUsersAsync();
    }

    public class ResponseUserService : IResponseUsersService
    {
        private readonly HttpClient _httpClient;

        public ResponseUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseUsers> GetListUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<ResponseUsers>("https://reqres.in/api/users?page=2");
        }
    }
}