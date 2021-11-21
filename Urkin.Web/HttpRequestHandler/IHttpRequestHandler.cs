using System.Threading.Tasks;
using Urkin.Models;

namespace Urkin.Web
{
    /// <summary>
    /// Provides actions to handle typed HTTP requests
    /// </summary>
    public interface IHttpRequestHandler
    {
        /// <summary>
        /// Handles typed HTTP requests and inverts control to the appropriate service
        /// </summary>
        /// <typeparam name="TRequest">The type of the request</typeparam>
        /// <param name="request">The request to handle</param>
        /// <returns>An instance of <see cref="HttpRequestHandlerResult"/></returns>
        Task<HttpRequestHandlerResult> Handle<TRequest>(TRequest request);
    }
}
