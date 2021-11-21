using System.Threading.Tasks;

namespace Urkin.Web
{
    /// <summary>
    /// Represents 409 (conflict) instance of the <see cref="IStatusCodeResolver"/>
    /// </summary>
    public class StatusCode409ConflictResolver : IStatusCodeResolver
    {
        /// <summary>
        /// Returns 409 (conflict) HTTP status code
        /// </summary>
        /// <returns>HTTP status code 409 (conflict)</returns>
        public Task<int> Resolve()
        {
            return Task.FromResult(409);
        }
    }
}
