using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 407 (proxy authentication required) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode407ProxyAuthenticationRequiredResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 407 (proxy authentication required) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 407 (proxy authentication required)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(407);
        }
    }
}
