using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 204 (no content) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode204NoContentResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 204 (no content) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 204 (no content)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(204);
        }
    }
}
