using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 502 (bad gateway) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode502BadGatewayResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 502 (bad gateway) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 502 (bad gateway)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(502);
        }
    }
}
