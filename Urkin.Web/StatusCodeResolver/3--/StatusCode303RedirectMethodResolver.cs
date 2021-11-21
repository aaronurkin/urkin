using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 303 (redirect method) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode303RedirectMethodResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 303 (redirect method) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 303 (redirect method)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(303);
        }
    }
}
