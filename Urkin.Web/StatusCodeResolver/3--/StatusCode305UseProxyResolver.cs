using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 305 (use proxy) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode305UseProxyResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 305 (use proxy) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 305 (use proxy)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(305);
        }
    }
}
