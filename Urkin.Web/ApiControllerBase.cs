using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// A base class for an API controller without view support.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        /// <summary>
        /// Constructor initializing <see cref="IHttpRequestHandler"/>.
        /// </summary>
        /// <param name="requestHandler">An instance of the <see cref="IHttpRequestHandler"/>.</param>
        public ApiControllerBase(IHttpRequestHandler requestHandler)
        {
            this.RequestHandler = requestHandler ?? throw new System.ArgumentNullException(nameof(requestHandler));
        }

        /// <summary>
        /// Gets the <see cref="IHttpRequestHandler"/> to handle a request.
        /// </summary>
        protected virtual IHttpRequestHandler RequestHandler { get; }

        /// <summary>
        /// Handles a request and resolves a <see cref="StatusCodeResult"/> object by specifying a statusCode
        /// with or without value according to a request handler result.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request body.</typeparam>
        /// <param name="request">The request instance to handle.</param>
        /// <returns>The created <see cref="StatusCodeResult"/> object for the response.</returns>
        protected virtual async Task<IActionResult> Handle<TRequest>(TRequest request)
        {
            var result = await this.RequestHandler
                .Handle(request);

            if (result.Data == null)
            {
                return this.StatusCode(result.StatusCode);
            }

            return this.StatusCode(result.StatusCode, result.Data);
        }
    }
}
