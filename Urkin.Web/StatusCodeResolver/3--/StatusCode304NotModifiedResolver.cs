using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 304 (not modified) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode304NotModifiedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 304 (not modified) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 304 (not modified)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(304);
        }
    }
}
