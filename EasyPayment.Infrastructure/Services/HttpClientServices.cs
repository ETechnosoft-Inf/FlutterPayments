using EasyPayment.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment.Infrastructure.Services
{
    public class HttpClientServices : IHttpClientHelper
    {
        private readonly IConfiguration _configuration;
        private string baseURL = string.Empty;
        private string accessTokenbaseURL = string.Empty;
        public HttpClientServices(IConfiguration configuration)
        {
            _configuration = configuration;
            baseURL = _configuration.GetValue<string>("BASE_URL");
        }
        public async Task<T> GetAsync<T>(string path) where T : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var response = await client.GetAsync(path);
            if (!response.IsSuccessStatusCode)
                throw new Exception("The request was not successful...");
            string result = response.Content.ReadAsStringAsync().Result;
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<T> GetAsync<T>(string path, string token) where T : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);

            client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync(path);
            if (!response.IsSuccessStatusCode)
                throw new Exception("The request was not successful...");
            string result = response.Content.ReadAsStringAsync().Result;
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<bool> GetDatatAsync(string path)
        {
            var client = new HttpClient();
            //// client.BaseAddress = new Uri(baseURL);
            var response = await client.GetAsync(path);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> GetDatatAsync(string path, string token)
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync(path);
            return response.IsSuccessStatusCode;
        }

        public async Task<T> PostAsync<T, M>(M detail, string path)
            where T : class
            where M : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var jsonContent = JsonConvert.SerializeObject(detail);
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(path, data);
            string result = response.Content.ReadAsStringAsync().Result;
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<T> PostAsync<T, M>(M detail, string path, string token)
            where T : class
            where M : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var jsonContent = JsonConvert.SerializeObject(detail);
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PostAsync(path, data);
            string result = response.Content.ReadAsStringAsync().Result;
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<bool> PostAsync<M>(M detail, string path) where M : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var jsonContent = JsonConvert.SerializeObject(detail);
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(path, data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> PostAsync<M>(M detail, string path, string token) where M : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var jsonContent = JsonConvert.SerializeObject(detail);
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PostAsync(path, data);
            return response.IsSuccessStatusCode;
        }

        public async Task<T> PostDataAsync<T, M>(M detail, string path)
            where T : struct
            where M : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var jsonContent = JsonConvert.SerializeObject(detail);
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(path, data);
            if (!response.IsSuccessStatusCode)
                throw new Exception();
            string result = response.Content.ReadAsStringAsync().Result;
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<T> PostDataAsync<T, M>(M detail, string path, string token)
            where T : struct
            where M : class
        {
            var client = new HttpClient();
            // client.BaseAddress = new Uri(baseURL);
            var jsonContent = JsonConvert.SerializeObject(detail);
            var data = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(path, data);
            if (!response.IsSuccessStatusCode)
                throw new Exception();
            string result = response.Content.ReadAsStringAsync().Result;
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<T> PostFormAsync<T>(List<KeyValuePair<string, string>> keyValues, string path) where T : class
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(accessTokenbaseURL);
            var request = new HttpRequestMessage(HttpMethod.Post, path);
            request.Content = new FormUrlEncodedContent(keyValues);

            var response = await client.SendAsync(request);
            string result = await response.Content.ReadAsStringAsync();
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

        public async Task<T> PostFormAsync<T>(List<KeyValuePair<string, string>> keyValues, string path, string token) where T : class
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(accessTokenbaseURL);
            var request = new HttpRequestMessage(HttpMethod.Post, path);
            request.Content = new FormUrlEncodedContent(keyValues);
            client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.SendAsync(request);
            string result = await response.Content.ReadAsStringAsync();
            T returnValue = JsonConvert.DeserializeObject<T>(result);
            return returnValue;
        }

    }
}
