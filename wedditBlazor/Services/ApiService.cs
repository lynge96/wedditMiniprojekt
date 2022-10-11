using System;
using System.Net.Http.Json;
using shared.Model;

namespace wedditBlazor.Services
{
    public class ApiService
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";

        public event Action RefreshRequired;

        public ApiService(HttpClient http, IConfiguration configuration)
        {
            this.http = http;
            this.configuration = configuration;
            this.baseAPI = configuration["base_api"];
        }

        public async Task<Post[]> GetPosts()
        {
            string url = $"{baseAPI}posts/";
            return await http.GetFromJsonAsync<Post[]>(url);
        }
    }
}

