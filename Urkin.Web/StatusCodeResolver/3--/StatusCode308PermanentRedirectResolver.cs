using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 308 (permanent redirect) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode308PermanentRedirectResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 308 (permanent redirect) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 308 (permanent redirect)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(308);
        }
    }
}
