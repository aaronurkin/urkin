using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 302 (found) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode302FoundResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 302 (found) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 302 (found)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(302);
        }
    }
}
