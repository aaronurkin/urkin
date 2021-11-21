using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 429 (too many requests) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode429TooManyRequestsResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 429 (too many requests) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 429 (too many requests)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(429);
        }
    }
}
