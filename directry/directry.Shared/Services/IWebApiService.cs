using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace directry.Services
{
    public interface IWebApiService
    {
        Task<string> PostAsync(Uri postUri, string postBody);
        Task<string> GetAsync(Uri requestUri);
        Task<string> PostAsync(Uri postUri, string postBody, CancellationToken cancellationToken);
        Task<string> GetAsync(Uri requestUri, CancellationToken cancellationToken);
    }
}
