using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 405 (method not allowed) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode405MethodNotAllowedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 405 (method not allowed) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 405 (method not allowed)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(405);
        }
    }
}
