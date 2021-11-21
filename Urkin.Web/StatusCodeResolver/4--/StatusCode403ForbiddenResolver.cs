using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 403 (forbidden) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode403ForbiddenResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 403 (forbidden) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 403 (forbidden)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(403);
        }
    }
}
