using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 416 (requested range not satisfiable) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode416RequestedRangeNotSatisfiableResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 416 (requested range not satisfiable) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 416 (requested range not satisfiable)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(416);
        }
    }
}
