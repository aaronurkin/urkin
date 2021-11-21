using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 302 (redirect) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode302RedirectResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 302 (redirect) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 302 (redirect)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(302);
        }
    }
}
