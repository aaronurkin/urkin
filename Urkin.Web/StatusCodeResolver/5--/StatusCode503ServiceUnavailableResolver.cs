using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 503 (service unavailable) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode503ServiceUnavailableResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 503 (service unavailable) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 503 (service unavailable)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(503);
        }
    }
}
