using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace directry.Services
{
    public class WebApiService : IWebApiService
    {
        private static IWebApiService instance;

        public static IWebApiService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WebApiService();
                }
                return instance;
            }
        }

        public async Task<string> PostAsync(Uri postUri, string postBody)
        {
            //return await this.PostAsync(postUri, postBody, CancellationToken.None);
            using (var httpClient = new HttpClient())
            {
                var postData = new StringContent(postBody, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(postUri, postData);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

                
        public async Task<string> GetAsync(Uri requestUri)
        {
            return await this.GetAsync(requestUri, CancellationToken.None);
        }
        
        public async Task<string> PostAsync(Uri postUri, string postBody, CancellationToken cancellationToken)
        {
            using (var httpClient = new HttpClient())
            {
                var postData = new StringContent(postBody, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(postUri, postData, cancellationToken);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
        
        public async Task<string> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(requestUri, cancellationToken);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
