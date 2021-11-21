using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 504 (gateway timeout) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode504GatewayTimeoutResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 504 (gateway timeout) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 504 (gateway timeout)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(504);
        }
    }
}
