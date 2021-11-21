using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 404 (not found) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode404NotFoundResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 404 (not found) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 404 (not found)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(404);
        }
    }
}
