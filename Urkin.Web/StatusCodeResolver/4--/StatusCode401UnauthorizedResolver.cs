using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 401 (unauthorized) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode401UnauthorizedResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 401 (unauthorized) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 401 (unauthorized)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(401);
        }
    }
}
