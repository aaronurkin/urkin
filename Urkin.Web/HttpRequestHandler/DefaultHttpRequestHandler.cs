using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Urkin.DependencyInjection;
using Urkin.Models;
using Urkin.Services;

namespace Urkin.Web
{
    /// <summary>
    /// Default implementation of the <see cref="IHttpRequestHandler"/>
    /// </summary>
    public class DefaultHttpRequestHandler : IHttpRequestHandler
    {
        private readonly ILogger logger;
        private readonly IDependenciesResolver dependenciesResolver;

        /// <summary>
        /// Constructor initializes the <see cref="ILogger"/> and <see cref="IDependenciesResolver"/> instances
        /// </summary>
        /// <param name="logger">The logger instance</param>
        /// <param name="dependenciesResolver">The resolver instance</param>
        public DefaultHttpRequestHandler(
            ILogger<DefaultHttpRequestHandler> logger,
            IDependenciesResolver dependenciesResolver
        )
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            this.dependenciesResolver = dependenciesResolver ?? throw new System.ArgumentNullException(nameof(dependenciesResolver));
        }

        /// <summary>
        /// Handles typed HTTP requests and inverts control to the appropriate service
        /// </summary>
        /// <typeparam name="TRequest">The type of the request</typeparam>
        /// <param name="request">The request to handle</param>
        /// <returns>An instance of <see cref="HttpRequestHandlerResult"/></returns>
        public virtual async Task<HttpRequestHandlerResult> Handle<TRequest>(TRequest request)
        {
            try
            {
                var names = await this.dependenciesResolver
                    .Resolve<IServiceNamesResolver>()
                    .Resolve();

                var result = await this.dependenciesResolver
                    .ResolveNamed<IApplicationManager<TRequest>>(names.Items)
                    .Manage(request);

                var statusCode = await this.dependenciesResolver
                    .ResolveKeyed<IStatusCodeResolver>(result.Type)
                    .Resolve();

                var responseBody = (result as IDataExtendable)?.Data;

                return new HttpRequestHandlerResult(responseBody, statusCode);
            }
            catch (System.Exception exception)
            {
                this.logger.LogCritical(exception, "FAILED handling {0}", (request?.GetType() ?? typeof(TRequest)).FullName);
                return new HttpRequestHandlerResult((int)System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
