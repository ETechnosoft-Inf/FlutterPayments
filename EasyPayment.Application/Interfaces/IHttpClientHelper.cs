using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyPayment.Application.Interfaces
{
    public interface IHttpClientHelper
    {
        Task<T> PostAsync<T, M>(M detail, string path) where T : class where M : class;
        Task<T> PostAsync<T, M>(M detail, string path, string token) where T : class where M : class;
        Task<bool> PostAsync<M>(M detail, string path) where M : class;
        Task<bool> PostAsync<M>(M detail, string path, string token) where M : class;
        Task<T> PostDataAsync<T, M>(M detail, string path) where M : class where T : struct;
        Task<T> PostDataAsync<T, M>(M detail, string path, string token) where M : class where T : struct;
        Task<T> PostFormAsync<T>(List<KeyValuePair<string, string>> keyValues, string path) where T : class;
        Task<T> PostFormAsync<T>(List<KeyValuePair<string, string>> keyValues, string path, string token) where T : class;
        Task<T> GetAsync<T>(string path) where T : class;
        Task<T> GetAsync<T>(string path, string token) where T : class;
        Task<bool> GetDatatAsync(string path);
        Task<bool> GetDatatAsync(string path, string token);
    }
}
