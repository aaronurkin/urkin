using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 431 (request header fields too large) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode431RequestHeaderFieldsTooLargeResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 431 (request header fields too large) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 431 (request header fields too large)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(431);
        }
    }
}
